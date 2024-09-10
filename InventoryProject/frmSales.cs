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
    public partial class frmSales : Sample
    {
        public frmSales()
        {
            InitializeComponent();
            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;


            txtSearch.GotFocus += SearchTextBox_GotFocus;
            txtSearch.LostFocus += SearchTextBox_LostFocus;
            LoadSales();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public void LoadSales()
        {
            int i = 0;
            dgvSales.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tblSales ORDER BY odate DESC", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvSales.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }

            dr.Close();
            con.Close();
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



        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmSalesModule saleModule = new frmSalesModule();
            saleModule.btnAddOrder.Enabled = true;
            saleModule.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                row.Visible = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value.ToString().ToLower().Contains(searchTerm));
            }
        }

       

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSales.Rows.Count)
            {
                string colName = dgvSales.Columns[e.ColumnIndex].Name;

                if (colName == "dgvDel")
                {
                    if (MessageBox.Show("Delete this Order?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (dgvSales.Rows[e.RowIndex] != null && dgvSales.Rows[e.RowIndex].Cells[1] != null)
                        {
                            con.Open();
                            // Use parameterized query to prevent SQL injection
                            cmd = new SqlCommand("DELETE FROM tblSales WHERE oid LIKE @OrderId", con);
                            cmd.Parameters.AddWithValue("@OrderId", dgvSales.Rows[e.RowIndex].Cells[1].Value.ToString());
                            cmd.ExecuteNonQuery();
                            con.Close();

                            frmTransaction transactionForm = new frmTransaction();
                            transactionForm.DeleteOrderAndLogTransaction();


                            MessageBox.Show("Record has been successfully deleted!");
                        }
                    }
                }
            }
        }
    }
}
