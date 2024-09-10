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

namespace InventoryProject
{
    public partial class frmUserModule : Sample
    {
        public frmUserModule()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();


        //para di umulit registration
        private bool IsUsernameAlreadyExists(string username)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM admin WHERE username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if username, password, and phone are empty
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrWhiteSpace(txtCheckPass.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Please enter all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsUsernameAlreadyExists(txtUsername.Text))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtUsername.Text.Length > 12)
                {
                    MessageBox.Show("Username must be 12 characters or less", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtUsername.Text.Length < 4)
                {
                    MessageBox.Show("Username must be more than 4 character", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtPass.Text != txtCheckPass.Text)
                {
                    MessageBox.Show("Password did not match!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtPass.Text.Length < 6 || !txtPass.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Password should be at least 6 characters long and contain at least one digit", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Validate phone number
                if (!IsPhoneNumberValid(txtPhone.Text))
                {
                    MessageBox.Show("Invalid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Save user
                if (MessageBox.Show("Save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO admin(username, pass, phone) VALUES(@username, @pass, @phone)", con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.Close();
                    MessageBox.Show("User has been successfully saved.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Check if the phone number is numeric
            if (!long.TryParse(phoneNumber, out _))
            {
                return false;
            }

            // Check if the phone number is 11 digits and starts with "09"
            return phoneNumber.Length == 11 && phoneNumber.StartsWith("09");
        }


        public void Clear()
        {
            txtUsername.Clear();
            txtPass.Clear();
            txtCheckPass.Clear();
            txtPhone.Clear();

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Check if username, password, and phone are empty
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrWhiteSpace(txtCheckPass.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Please enter all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtUsername.Text.Length > 12)
                {
                    MessageBox.Show("Username must be 12 characters or less", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtPass.Text != txtCheckPass.Text)
                {
                    MessageBox.Show("Password did not match!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate phone number
                if (!IsPhoneNumberValid(txtPhone.Text))
                {
                    MessageBox.Show("Invalid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE admin SET username=@username,pass=@pass,phone=@phone WHERE id LIKE '" + lblId.Text + "' ", con);

                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User is successfully updated.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
