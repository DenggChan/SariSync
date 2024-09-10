using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProject
{
    public partial class frmSalesModule : Sample
    {
        public frmSalesModule()
        {
            InitializeComponent();
            LoadCustomers();
            LoadProduct();

            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;


            // Attach event handlers
            txtSearch.GotFocus += SearchTextBox_GotFocus;
            txtSearch.LostFocus += SearchTextBox_LostFocus;

            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            txtQty.TextChanged += txtQty_TextChanged;

            dtPickerSDate.Format = DateTimePickerFormat.Custom;
            dtPickerSDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";


        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadCustomers()
        {
            cbCustomer.Items.Clear();

            cmd = new SqlCommand("SELECT cname FROM tblCustomer", con);


            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbCustomer.Items.Add(dr["cname"].ToString());
            }

            dr.Close();
            con.Close();

            // Set ComboBox properties
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDown;
            cbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbCustomer.Focus();
        }

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
                dgvProducts.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), dr[6].ToString());
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                row.Visible = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value.ToString().ToLower().Contains(searchTerm));
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
               if (dgvProducts.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

               
                int productNameColumnIndex = 2;
                int priceColumnIndex = 4;
                int qtyColumnIndex = 3;

                
                string productName = selectedRow.Cells[productNameColumnIndex].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells[priceColumnIndex].Value);
                int qty = Convert.ToInt32(selectedRow.Cells[qtyColumnIndex].Value);


                // Update the textboxes
                txtPName.Text = productName;
                txtPrice.Text = "₱" + price.ToString("N2");
                txtAvailQty.Text = qty.ToString(); ;
              

                // Validate the inputs
                ValidateInputs();
                ValidateInputs1();
            }
            else
            {
                // Clear the textboxes if no row is selected
                txtPName.Clear();
                txtPrice.Clear();
                txtAvailQty.Clear();
                txtQty.Clear();
            }  

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtPName.Text))
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Please enter a valid value for quantity.");
                return;
            }

            if (!int.TryParse(txtQty.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Inputs are valid, you can proceed if needed
        }

        public void ValidateInputs1()
        {
            if (!string.IsNullOrEmpty(txtQty.Text) && !string.IsNullOrEmpty(txtAvailQty.Text))
            {
                int enteredQty = Convert.ToInt32(txtQty.Text);
                int availQty = Convert.ToInt32(txtAvailQty.Text);

                if (enteredQty > availQty)
                {
                    MessageBox.Show("Entered quantity cannot exceed available quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Optionally clear the txtQty to prevent further actions
                    txtQty.Clear();
                }
            }
        }



        private void txtPName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("txtQty_TextChanged event fired.");

            ValidateInputs1();

        }

        private void UpdateGrandTotal()
        {
            decimal grandTotal = 0;

            // Iterate through each row in dgvOrderTab and sum up the amounts
            foreach (DataGridViewRow row in dgvOrderTab.Rows)
            {
                if (row.Cells[3].Value != null && decimal.TryParse(row.Cells[3].Value.ToString(), out decimal amount))
                {
                    grandTotal += amount;
                }
            }

            // Display the grand total in lblGTotal
            lblGTotal.Text = $"₱{grandTotal.ToString("N2")}";
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPName.Text))
            {
                // Your existing logic for adding an order
                string productName = txtPName.Text;

                // Check if the product is already added
                if (IsProductAlreadyAdded(productName))
                {
                    MessageBox.Show("This product is already added to the order.");
                    return;  // Exit the method to prevent duplicate entries
                }

                decimal price;

                // Check if txtPrice has a value before parsing
                if (!string.IsNullOrEmpty(txtPrice.Text))
                {
                    // Use the existing content of txtPrice without parsing again
                    price = decimal.Parse(txtPrice.Text.Replace("₱", ""));
                }
                else
                {
                    // Handle the case where txtPrice is empty
                    price = 0; // or any default value as needed
                }

                if (int.TryParse(txtQty.Text, out int quantity))
                {
                    decimal amount = price * quantity;
                    dgvOrderTab.Rows.Add(productName, quantity, price, amount);

                    txtPName.Clear();
                    txtPrice.Clear();
                    txtQty.Clear();
                    txtAvailQty.Clear();

                    UpdateGrandTotal();
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for Quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }

        }

        private bool IsProductAlreadyAdded(string productName)
        {
            foreach (DataGridViewRow row in dgvOrderTab.Rows)
            {
                if (row.Cells["productName"].Value != null &&
                    row.Cells["productName"].Value.ToString() == productName)
                {
                    return true; // Product is already added
                }
            }

            return false;
        }


        private void dgvOrderTab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderTab.Columns[e.ColumnIndex].Name == "dgvDel" && e.RowIndex >= 0)
            {
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Remove the selected row
                    dgvOrderTab.Rows.RemoveAt(e.RowIndex);

                    // Update the grand total after deleting a row
                    UpdateGrandTotal();
                }
            }

        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbCustomer.Text))
                {
                    MessageBox.Show("Please select a customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvOrderTab.Rows.Count == 0)
                {
                    MessageBox.Show("No items in the order. Please add items before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to save this order? Once saved, it cannot be changed.", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DateTime odate = DateTime.Now;

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tblSales (cname, pname, oqty, oprice, oamount, odate)" +
                        "VALUES (@cname, @pname, @oqty, @oprice, @oamount, @odate)", con))
                    {
                        cmd.Parameters.AddWithValue("@cname", cbCustomer.Text);

                        con.Open();

                        foreach (DataGridViewRow row in dgvOrderTab.Rows)
                        {
                            int pnameColIndex = dgvOrderTab.Columns["productName"].Index;
                            int oqtyColIndex = dgvOrderTab.Columns["QtyCol"].Index;
                            int opriceColIndex = dgvOrderTab.Columns["PriceCol"].Index;
                            int amountColIndex = dgvOrderTab.Columns["AmountCol"].Index;

                            cmd.Parameters.Clear(); // Clear parameters for the insert command

                            cmd.Parameters.AddWithValue("@cname", cbCustomer.Text);
                            cmd.Parameters.AddWithValue("@pname", row.Cells[pnameColIndex].Value.ToString());
                            cmd.Parameters.AddWithValue("@oqty", Convert.ToInt16(row.Cells[oqtyColIndex].Value));
                            cmd.Parameters.AddWithValue("@oprice", Convert.ToDecimal(row.Cells[opriceColIndex].Value));
                            cmd.Parameters.AddWithValue("@oamount", Convert.ToDecimal(row.Cells[amountColIndex].Value));
                            cmd.Parameters.AddWithValue("@odate", odate);

                            cmd.ExecuteNonQuery();

                            // Update product quantity
                            using (SqlCommand updateCmd = new SqlCommand("UPDATE tblProduct SET pqty -= @pqty WHERE pname LIKE @pname", con))
                            {
                                updateCmd.Parameters.AddWithValue("@pqty", Convert.ToInt16(row.Cells[oqtyColIndex].Value));
                                updateCmd.Parameters.AddWithValue("@pname", row.Cells[pnameColIndex].Value.ToString() + "%"); // Use LIKE to match similar names

                                updateCmd.ExecuteNonQuery();

                            }

                        }

                        this.Close();
                        con.Close();

                        frmTransaction transactionForm = new frmTransaction();
                        transactionForm.AddOrderAndLogTransaction();


                        MessageBox.Show("Order has been successfully saved.");
                        Clear();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void Clear()
        {
            txtQty.Clear();
            cbCustomer.Text = "";
            dgvOrderTab.Rows.Clear();
            UpdateGrandTotal();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblGTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblOId_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (string.IsNullOrWhiteSpace(searchTerm) || searchTerm == "search")
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value.ToString().ToLower().Contains(searchTerm));
                }
            }

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dgvProducts.ClearSelection();
                dgvProducts.CurrentCell = null;
            }
        }
    }
    }

