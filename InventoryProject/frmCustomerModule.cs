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
    public partial class frmCustomerModule : Sample
    {
        public frmCustomerModule()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsUsernameAlreadyExists(string cname)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM tblCustomer WHERE cname = @cname";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cname", cname);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if name, phone, and if the name contains numbers
                if (string.IsNullOrWhiteSpace(txtCName.Text) || string.IsNullOrWhiteSpace(txtCPhone.Text))
                {
                    MessageBox.Show("Please enter all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsUsernameAlreadyExists(txtCName.Text))
                {
                    MessageBox.Show("Name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate that the name does not contain numbers
                if (ContainsNumbers(txtCName.Text))
                {
                    MessageBox.Show("Invalid name. Name must not contain numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate phone number
                if (!IsPhoneNumberValid(txtCPhone.Text))
                {
                    MessageBox.Show("Invalid phone number. Please enter a valid 11-digit number starting with 09.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Save this customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tblCustomer (cname, cphone) VALUES (@cname, @cphone)", con))
                    {
                        cmd.Parameters.AddWithValue("@cname", txtCName.Text);
                        cmd.Parameters.AddWithValue("@cphone", txtCPhone.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        this.Close();
                        MessageBox.Show("Customer has been successfully saved.");
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            if (!long.TryParse(phoneNumber, out _))
            {
                return false;
            }

            return phoneNumber.Length == 11 && phoneNumber.StartsWith("09");
        }

        private bool ContainsNumbers(string input)
        {
            return input.Any(char.IsDigit);
        }

        public void Clear()
        {
            txtCName.Clear();
            txtCPhone.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if name, phone, and if the name contains numbers
                if (string.IsNullOrWhiteSpace(txtCName.Text) || string.IsNullOrWhiteSpace(txtCPhone.Text))
                {
                    MessageBox.Show("Please enter all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate that the name does not contain numbers
                if (ContainsNumbers(txtCName.Text))
                {
                    MessageBox.Show("Invalid name. Name must not contain numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate phone number
                if (!IsPhoneNumberValid(txtCPhone.Text))
                {
                    MessageBox.Show("Invalid phone number. Please enter a valid 11-digit number starting with 09.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this Customer?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tblCustomer SET cname=@cname, cphone=@cphone WHERE cid LIKE '" + lblCId.Text + "' ", con);

                    cmd.Parameters.AddWithValue("@cname", txtCName.Text);
                    cmd.Parameters.AddWithValue("@cphone", txtCPhone.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer is successfully updated.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
