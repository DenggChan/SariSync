using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using InventoryProject.Db;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace InventoryProject.Model
{

    //use struct for more consistency
    public struct RevenueDate
    {
        public string Date { get; set; }
        public decimal totalAmount { get; set; }
    }

    //dashboard for data analytics inherit from abstract class dbcon
    class Dashboard : DbCon
    {
        // Fields in the dashboard
        private DateTime startD;
        private DateTime endD;
        private int numDays;

        // Number of products
        public int NumProducts { get; private set; }
        public int NumCustomers { get; private set; }

        public List<KeyValuePair<string, int>> TopProductList { get; private set; }
        public List<KeyValuePair<string, int>> UnderStockList { get; private set; }
        public List<RevenueDate> GrossRevenueList { get; private set; }

        public int NumOrders { get; set; }
        public decimal totalRevenue { get; set; }
        public decimal totalProfit { get; set; }


        public Dashboard()
        {
            
        }

        private void GetNumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    //GET TOTAL Customers
                    command.CommandText = "select count(cid) from tblCustomer";
                    NumCustomers= (int)command.ExecuteScalar();

                    //GET TOTAL Products
                    command.CommandText = "select count(pid) from tblProduct";
                    NumProducts = (int)command.ExecuteScalar();

                    //GET TOTAL Orders
                    command.CommandText = @"select count(oid) from [tblSales]" +
                        "where odate between @fromD and @toD";
                    command.Parameters.Add("@fromD", System.Data.SqlDbType.DateTime).Value = startD;
                    command.Parameters.Add("@ToD", System.Data.SqlDbType.DateTime).Value = endD;
                    NumOrders = (int)command.ExecuteScalar();

                }
            }
        }
        private void GetOrderAnalysis()
        {
            GrossRevenueList = new List<RevenueDate>();
            totalProfit = 0;
            totalRevenue = 0;

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"SELECT odate, SUM(oqty * oprice) AS totalAmount " +
                                          "FROM [tblSales] " +
                                          "WHERE odate BETWEEN @fromD AND @toD " +
                                          "GROUP BY odate";

                    command.Parameters.Add("@fromD", System.Data.SqlDbType.DateTime).Value = startD;
                    command.Parameters.Add("@ToD", System.Data.SqlDbType.DateTime).Value = endD;

                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();

                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader["totalAmount"]));
                        totalRevenue += (decimal)reader["totalAmount"];
                    }

                    reader.Close();

                    // Calculate total cost
                    decimal totalCost = 0;

                    using (var costCommand = new SqlCommand())
                    {
                        costCommand.Connection = connection;
                        costCommand.CommandText = @"SELECT SUM(ppur * oqty) FROM [tblProduct] p 
                                     INNER JOIN [tblSales] s ON p.pname = s.pname
                                     WHERE s.odate BETWEEN @fromD AND @toD";
                        costCommand.Parameters.Add("@fromD", System.Data.SqlDbType.DateTime).Value = startD;
                        costCommand.Parameters.Add("@ToD", System.Data.SqlDbType.DateTime).Value = endD;

                        totalCost = (decimal)(costCommand.ExecuteScalar() ?? 0m);
                    }

                    // Calculate total profit
                    totalProfit = totalRevenue - totalCost;

                    // Group by time intervals
                    if (numDays <= 1)
                    {
                        GrossRevenueList =  (from orderList in resultTable
                         group orderList by orderList.Key.ToString("hh tt")
                         into order
                         select new RevenueDate
                         {
                             Date = order.Key,
                             totalAmount = order.Sum(item => item.Value)
                         }).ToList();

                    }
                    else if (numDays <= 30)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new RevenueDate
                                            {
                                                Date = order.Key,
                                                totalAmount = order.Sum(item => item.Value)
                                            }).ToList();
                    }

                    else if (numDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                totalAmount = order.Sum(item => item.Value)
                                            }).ToList();
                    }
                    else if (numDays <= (365 * 2))
                    {
                        bool isYear = numDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new RevenueDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                totalAmount = order.Sum(item => item.Value)
                                            }).ToList();
                    }

                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueDate
                                            {
                                                Date = order.Key,
                                                totalAmount = order.Sum(item => item.Value)
                                            }).ToList();
                    }
                }
            }
        }

        private void GetProductAnalysys()
        {

            //best seller and understock

            TopProductList = new List<KeyValuePair<string, int>>();
            UnderStockList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;

                    //get top5 best seller
                    command.CommandText = @"SELECT TOP 5 P.pname, SUM(O.oqty) AS Q
	                            	FROM tblSales O
		                            INNER JOIN tblProduct P ON P.pname = O.pname
	   	                            WHERE O.odate BETWEEN @fromD AND @toD
		                            GROUP BY P.pname
		                            ORDER BY Q DESC;";
                    command.Parameters.Add("@fromD", System.Data.SqlDbType.DateTime).Value = startD;
                    command.Parameters.Add("@ToD", System.Data.SqlDbType.DateTime).Value = endD;

                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    command.CommandText = @"select pname, pqty
		                            from tblProduct
	                            	where pqty <= 8
                                    ORDER BY pqty ASC;";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderStockList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                }
            }
        }

        public bool LoadData(DateTime startD, DateTime endD)
        {

            endD = new DateTime(endD.Year, endD.Month, endD.Day, endD.Hour, endD.Minute,endD.Second, 5);

            if (startD != this.startD || endD != this.endD)
            {
                this.startD = startD;
                this.endD = endD;
                this.numDays = (endD - startD).Days;

                GetNumberItems();
                GetOrderAnalysis();
                GetProductAnalysys();
                Console.WriteLine("Refreshed data {0} - {1}", startD.ToString(), endD.ToString());
                return true;

            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startD.ToString(), endD.ToString());
                return false;
            }
        }



    }
}


