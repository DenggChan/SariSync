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
    public partial class frmUser : Sample
    {
        public frmUser()
        {
            InitializeComponent();
            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;


            // Attach event handlers
            txtSearch.GotFocus += SearchTextBox_GotFocus;
            txtSearch.LostFocus += SearchTextBox_LostFocus;

            LoadUser();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM admin", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
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
  

        private void dgvUserFrm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   

        private void btnManage_Click(object sender, EventArgs e)
        {
          

            frmUserModule userModule = new frmUserModule();
            userModule.btnSave.Enabled = true;
            userModule.btnUpdate.Enabled = true;
            userModule.Show();
            LoadUser();

        }


        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "dgvEdit")
            {
                frmUserModule userModule = new frmUserModule();
                userModule.lblId.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtUsername.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtPass.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtPhone.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();

                userModule.btnSave.Enabled = true;
                userModule.btnUpdate.Enabled = true;
                userModule.ShowDialog();
            }
            else if (colName == "dgvDel")
            {
                if (MessageBox.Show("Delete this User?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM admin WHERE id LIKE '" + dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");

                }
            }
            LoadUser();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvUser.Rows)
            {
                row.Visible = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value.ToString().ToLower().Contains(searchTerm));
            }
        }

        private Form FindTopLevelForm(Control control)
        {
            while (control != null && control.Parent != null)
            {
                control = control.Parent;
            }

            return control as Form;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form frmMain = FindTopLevelForm(this);
                if (frmMain != null)
                {
                    frmMain.Hide();
                }

                frmLogin loginForm = new frmLogin();

                loginForm.FormClosed += (s, args) =>
                {
                    if (loginForm.DialogResult == DialogResult.OK)
                    {
                        frmMain?.Show();
                    }
                    else
                    {
                        // If the login is canceled or unsuccessful, exit the application
                        Application.Exit();
                    }
                };

                loginForm.ShowDialog();

            }

        }
    }
}
