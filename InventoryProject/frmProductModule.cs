using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace InventoryProject
{
    public partial class frmProductModule : Sample
    {
        public frmProductModule()
        {
            InitializeComponent();
            LoadCategory();
        }



        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadCategory()
        {
            cbPCategory.Items.Clear();
            cmd= new SqlCommand("SELECT catname FROM tblCategory", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                cbPCategory.Items.Add(dr["catname"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private bool IsProductAlreadyExists(string pname)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM tblProduct WHERE pname = @pname";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pname", pname);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (IsProductAlreadyExists(txtPName.Text))
                {
                    MessageBox.Show("Product already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPName.Text))
                {                  
                    lblNReq.Text = "*";
                    return; 
                }
                if (string.IsNullOrWhiteSpace(txtQty.Text))
                {
                    lblQReq.Text = "*";
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPurPrice.Text))
                {
                    lblPReq.Text = "*";
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSellPrice.Text))
                {
                    lblSReq.Text = "*";
                    return;
                }
                if (!int.TryParse(txtQty.Text, out int quantity))
                {     
                    lblQtyError.Text = "Invalid";
                    return;
                }
                if (quantity > 50)
                {
                    MessageBox.Show("Maximum quantity is 50", "Capacity limit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtPurPrice.Text, out decimal purchasePrice))
                {
                    MessageBox.Show("Invalid purchase price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtSellPrice.Text, out decimal sellingPrice))
                {
                    MessageBox.Show("Invalid selling price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (purchasePrice >= sellingPrice)
                {
                    MessageBox.Show("Purchase price should be less than the selling price.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Save this product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tblProduct (pid, pname, pqty, ppur, psell, pdate, pcategory) " +
                    "VALUES (@pid, @pname, @pqty, @ppur, @psell, @pdate, @pcategory)", con))

                    {
                        string shortId = GenerateRandomString(9);

                        cmd.Parameters.AddWithValue("@pid", shortId);
                        cmd.Parameters.AddWithValue("@pname", txtPName.Text); 
                        cmd.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtQty.Text));
                        cmd.Parameters.AddWithValue("@ppur", Convert.ToDecimal(txtPurPrice.Text));
                        cmd.Parameters.AddWithValue("@psell", Convert.ToDecimal(txtSellPrice.Text));
                        cmd.Parameters.AddWithValue("@pdate", dtPickerPDate.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@pcategory", cbPCategory.Text);
                   

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        frmTransaction transactionForm = new frmTransaction();
                        transactionForm.AddProductAndLogTransaction();


                        this.Close();
                        MessageBox.Show("Product has been successfully saved.");
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
            txtPName.Clear();
            txtQty.Clear();
            txtPurPrice.Clear();
            txtSellPrice.Clear();
            cbPCategory.Text = "";

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
                if (MessageBox.Show("Are you sure you want to update this Product?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tblProduct SET pname=@pname, pqty=@pqty, ppur=@ppur, psell=@psell, pdate=@pdate, pcategory=@pcategory" +
                        "  WHERE Pid LIKE '" + lblPId.Text + "' ", con);

                    cmd.Parameters.AddWithValue("@pname", txtPName.Text);
                    cmd.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtQty.Text));
                    cmd.Parameters.AddWithValue("@ppur", Convert.ToDecimal(txtPurPrice.Text));
                    cmd.Parameters.AddWithValue("@psell", Convert.ToDecimal(txtSellPrice.Text));
                    cmd.Parameters.AddWithValue("@pdate", dtPickerPDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@pcategory", cbPCategory.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    frmTransaction transactionForm = new frmTransaction();
                    transactionForm.UpdateProductAndLogTransaction();

                    MessageBox.Show("Product is successfully updated.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPurPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
