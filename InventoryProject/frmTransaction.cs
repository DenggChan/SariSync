using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProject
{
    public enum TransactionType
    {
        AddProduct,
        UpdateProduct,
        DeleteProduct,
        AddOrder,
        DeleteOrder
        
    }

    public partial class frmTransaction : Sample
    {
        
        public frmTransaction()
        {
            InitializeComponent();

            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;


            txtSearch.GotFocus += SearchTextBox_GotFocus;
            txtSearch.LostFocus += SearchTextBox_LostFocus;

            LoadTransaction();

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

      

        public void LoadTransaction()
        {
            int i = 0;
            dgvTransactionLog.Rows.Clear();

            DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6); 

            cmd = new SqlCommand("SELECT * FROM TransactionLog WHERE TransactionDate >= @SixMonthsAgo ORDER BY TransactionDate DESC", con);
            cmd.Parameters.AddWithValue("@SixMonthsAgo", sixMonthsAgo);

            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                i++;
                dgvTransactionLog.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), dr[1].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }





        public void AddOrderAndLogTransaction()
        {
            LogTransaction(TransactionType.AddOrder, frmMain.LoggedInUsername);
        }

        public void AddProductAndLogTransaction()
        {
            LogTransaction(TransactionType.AddProduct, frmMain.LoggedInUsername);
        }

        public void UpdateProductAndLogTransaction()
        {
            LogTransaction(TransactionType.UpdateProduct, frmMain.LoggedInUsername);
        }

        public void DeleteProductAndLogTransaction()
        {
            LogTransaction(TransactionType.DeleteProduct, frmMain.LoggedInUsername);
        }

        public void DeleteOrderAndLogTransaction()
        {
            LogTransaction(TransactionType.DeleteOrder, frmMain.LoggedInUsername);
        }



        private void LogTransaction(TransactionType transactionType, string username)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                string transactionID = GenerateRandomTransactionID();
                DateTime transactionDate = DateTime.Now;

                string query = "INSERT INTO TransactionLog (TransactionID, Username, TransactionType, TransactionDate) " +
                               "VALUES (@TransactionID, @Username, @TransactionType, @TransactionDate)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TransactionID", transactionID);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@TransactionType", transactionType.ToString());
                    cmd.Parameters.AddWithValue("@TransactionDate", transactionDate);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to generate a random transaction ID
        private string GenerateRandomTransactionID()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 12).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
          

        }

        private void SearchTextBox_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = string.Empty;
            }
        }
        private void SearchTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvTransactionLog.Rows)
            {
                row.Visible = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value.ToString().ToLower().Contains(searchTerm));
            }
        }





    }


    }

