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
    public partial class frmProducts : Sample
    {
        public frmProducts()
        {
            InitializeComponent();
            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;


            // Attach event handlers
            txtSearch.GotFocus += SearchTextBox_GotFocus;
            txtSearch.LostFocus += SearchTextBox_LostFocus;

            LoadProduct();
            CheckZeroQuantityProducts();

        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            frmProductModule prodModule = new frmProductModule();
            prodModule.btnSave.Enabled = true;
            prodModule.btnUpdate.Enabled = true;
            prodModule.Show();
            LoadProduct();
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public void LoadProduct()
        {
            int i = 0;
            dgvProducts.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tblProduct", con);

            cmd = new SqlCommand("SELECT * FROM tblProduct ORDER BY pname ASC", con);

            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProducts.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), Convert.ToDateTime(dr[5].ToString()).ToString("yyyy-MM-dd"), dr[6].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void CheckZeroQuantityProducts()
        {
            List<string> zeroQtyProducts = new List<string>();

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                // Assuming the column indices for product name and quantity are 2 and 3, respectively
                int productNameColIndex = 2;
                int qtyColIndex = 3;

                string dgvProductName = row.Cells[productNameColIndex].Value.ToString();
                int dgvQty = Convert.ToInt32(row.Cells[qtyColIndex].Value);

                if (dgvQty <= 0)
                {
                    zeroQtyProducts.Add(dgvProductName);
                }
            }

            if (zeroQtyProducts.Count > 0)
            {
                string productList = string.Join("\n", zeroQtyProducts);

                MessageBox.Show($"The following products have reached a quantity of 0:\n{productList}", "Inventory Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                row.Visible = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value.ToString().ToLower().Contains(searchTerm));
            }
        }


        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProducts.Columns[e.ColumnIndex].Name;
            if (colName == "dgvEdit")
            {
                frmProductModule prodModule = new frmProductModule();

                string selectQuery = "SELECT pid, pname, pqty, ppur, psell, pcategory FROM tblProduct WHERE pid = @pid";

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@pid", dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString()); 

                        con.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                prodModule.lblPId.Text = dr["pid"].ToString();
                                prodModule.txtPName.Text = dr["pname"].ToString();
                                prodModule.txtQty.Text = dr["pqty"].ToString();
                                prodModule.txtPurPrice.Text = dr["ppur"].ToString();
                                prodModule.txtSellPrice.Text = dr["psell"].ToString();
                                prodModule.cbPCategory.Text = dr["pcategory"].ToString();
                            }
                        }
                    }
                }

                prodModule.btnSave.Enabled = true;
                prodModule.btnUpdate.Enabled = true;
                prodModule.ShowDialog();
            }
            else if (colName == "dgvDel")
            {
                if (MessageBox.Show("Delete this Product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tblProduct WHERE pid LIKE '" + dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    frmTransaction transactionForm = new frmTransaction();
                    transactionForm.DeleteProductAndLogTransaction();


                    MessageBox.Show("Product has been successfully deleted!");
                }
            }

            LoadProduct();
        }


    }
}
