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
    public partial class frmCategoryModule : Sample
    {
        //constructor
        public frmCategoryModule()
        {
            InitializeComponent();
        }


        //Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();

        //to close form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //to validate
        private bool IsCategoryAlreadyExists(string catname)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM tblCategory WHERE catname = @catname";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@catname", catname);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        //to add category 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsCategoryAlreadyExists(txtCatName.Text))
                {
                    MessageBox.Show("Category already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Save this category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tblCategory (catname) VALUES (@catname)", con))
                    {
                        cmd.Parameters.AddWithValue("@catname", txtCatName.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        this.Close();
                        MessageBox.Show("Category has been successfully saved.");
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Clear()
        {
            txtCatName.Clear();
        
        }

        //to clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }


        //to update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {   if (MessageBox.Show("Are you sure you want to update this Category?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cmd = new SqlCommand("UPDATE tblCategory SET catname=@catname WHERE catid LIKE '" + lblCatId.Text + "' ", con);

                    cmd.Parameters.AddWithValue("@catname", txtCatName.Text);
 
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category is successfully updated.");
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
