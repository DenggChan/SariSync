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
    public partial class frmCustomers : Sample
    {
        public frmCustomers()
        {
            InitializeComponent();
            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;


            txtSearch.GotFocus += SearchTextBox_GotFocus;
            txtSearch.LostFocus += SearchTextBox_LostFocus;
            LoadCustomer();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public void LoadCustomer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tblCustomer", con);

            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
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


        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "dgvEdit")
            {
                frmCustomerModule cusModule = new frmCustomerModule();
                cusModule.lblCId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                cusModule.txtCName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                cusModule.txtCPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();

                cusModule.btnSave.Enabled = true;
                cusModule.btnUpdate.Enabled = true;
                cusModule.ShowDialog();
            }
            else if (colName == "dgvDel")
            {
                if (MessageBox.Show("Delete this customer?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tblCustomer WHERE cid LIKE '" + dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");

                }
            }
            LoadCustomer();
        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            frmCustomerModule cusModule = new frmCustomerModule();
            cusModule.btnSave.Enabled = true;
            cusModule.btnUpdate.Enabled = true;
            cusModule.Show();
            LoadCustomer();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                row.Visible = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value.ToString().ToLower().Contains(searchTerm));
            }
        }
    }
}
