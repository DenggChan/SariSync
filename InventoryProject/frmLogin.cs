using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace InventoryProject
{
    public partial class frmLogin : KryptonForm

    {
        public static string LoggedInUsername { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        //Access Database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");


        private void pictureBox1_Click(object sender, EventArgs e)
        {}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserNameLog.Text == "" && txtPasswordLog.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        String selectData = "SELECT * FROM admin WHERE username COLLATE Latin1_General_CS_AS = @username AND pass COLLATE Latin1_General_CS_AS = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, con))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUserNameLog.Text);
                            cmd.Parameters.AddWithValue("@pass", txtPasswordLog.Text);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            da.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged in Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string username = txtUserNameLog.Text;

                                string loggedInUsername = txtUserNameLog.Text;
                                frmMain mainForm = new frmMain();
                                mainForm.Tag = loggedInUsername;


                                new frmMain(username).Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting database " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }

        private void checkboxShowPassLog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPassLog.Checked)
            {
                txtPasswordLog.PasswordChar = '\0';
            }
            else
            {
                txtPasswordLog.PasswordChar = '●';
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
