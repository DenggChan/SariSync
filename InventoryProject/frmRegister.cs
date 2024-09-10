using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;


namespace InventoryProject
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

        }

        //Access Database
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    String checkUsername = "SELECT * FROM admin WHERE username = '" + txtUserNameReg.Text.Trim() + "'";

                    using (SqlCommand checkUser = new SqlCommand(checkUsername, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        da.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(txtUserNameReg.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtUserNameReg.Text == "" || txtPasswordReg.Text == "" || txtConfirmPassReg.Text == "")
                        {
                            MessageBox.Show("Username/Password fields are empty", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtUserNameReg.Text.Length > 12)
                        {
                            MessageBox.Show("Username must be 12 characters or less", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; 
                        }
                        else if (txtUserNameReg.Text.Length < 4)
                        {
                            MessageBox.Show("Username must be more than 4 characters", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (string.IsNullOrWhiteSpace(txtPhone.Text))
                        {
                            MessageBox.Show("Phone field is empty", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtPhone.Text.Length != 11 || !txtPhone.Text.All(char.IsDigit))
                        {
                            MessageBox.Show("Please enter a valid 11-digit phone number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtPasswordReg.Text != txtConfirmPassReg.Text)
                        {
                            MessageBox.Show("Passwords don't match", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPasswordReg.Text = "";
                            txtConfirmPassReg.Text = "";
                            txtPasswordReg.Focus();
                        }
                        else if (txtPasswordReg.Text.Length < 6 || !txtPasswordReg.Text.Any(char.IsDigit))
                        {
                            MessageBox.Show("Password should be at least 6 characters long and contain at least one digit", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO admin (username, pass, date_created, phone)" +
                                "VALUES(@username, @pass, @date, @phone)";

                            DateTime date = DateTime.Today;
                            using (SqlCommand cmd = new SqlCommand(insertData, con))
                            {
                                cmd.Parameters.AddWithValue("@username", txtUserNameReg.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", txtPasswordReg.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", date);
                                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Your Account has been Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void checkboxShowPassReg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPassReg.Checked)
            {
                txtPasswordReg.PasswordChar = '\0';
                txtConfirmPassReg.PasswordChar = '\0';
            }
            else
            {
                txtPasswordReg.PasswordChar = '●';
                txtConfirmPassReg.PasswordChar = '●';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
