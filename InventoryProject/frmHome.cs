using InventoryProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProject
{
    public partial class frmHome : Sample
    {
        private Dashboard Model;
        private Button currentButton;

        public frmHome()
        {
            InitializeComponent();

            //custom for datetimepicker
            dtpstartD.Value = DateTime.Today.AddDays(-6);
            dtpendD.Value = DateTime.Now;


            btnLast7.Select();
            SetDateMenuButtons(btnLast7);

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();

            Model = new Dashboard();
            LoadData();

        }

        private void LoadData()
        {
            var refreshData = Model.LoadData(dtpstartD.Value, dtpendD.Value);
            if (refreshData == true)
            {
                lblNumOrders.Text = Model.NumOrders.ToString();
                lblTotalRevenue.Text = "₱" + Model.totalRevenue.ToString();
                lblTotalProfit.Text = "₱" + Model.totalProfit.ToString();

                lblNumCustomers.Text = Model.NumCustomers.ToString();
                lblNumProducts.Text = Model.NumProducts.ToString();

                chartGrossRevenue.DataSource = Model.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "totalAmount";
                chartGrossRevenue.DataBind();

                chartTopProducts.DataSource = Model.TopProductList;
                chartTopProducts.Series[0].XValueMember = "Key";
                chartTopProducts.Series[0].YValueMembers = "Value";
                chartTopProducts.DataBind();

                dgvUnderstock.DataSource = Model.UnderStockList;
                dgvUnderstock.Columns[0].HeaderText = "Product Name";
                dgvUnderstock.Columns[1].HeaderText = "Qty";

                Console.WriteLine("Loaded view ");

            }
            else Console.WriteLine("View not loaded");
        }

        private void SetDateMenuButtons(object button)
        {
            var btn = (Button)button;

            //highlight sa button
            btn.BackColor = btnLast30.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;


            //unhighlight
            if (currentButton != null && currentButton != btn)
            {

                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(124, 141, 181);

            }

            currentButton = btn;
         

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpstartD.Value = DateTime.Today;
            dtpendD.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtons(sender);
        }

        private void btnLast7_Click(object sender, EventArgs e)
        {
            dtpstartD.Value = DateTime.Today.AddDays(-6);
            dtpendD.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtons(sender);
        }

        private void btnLast30_Click(object sender, EventArgs e)
        {
            dtpstartD.Value = DateTime.Today.AddDays(-30);
            dtpendD.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtons(sender);
        }

        private void btnThisM_Click(object sender, EventArgs e)
        {
            dtpstartD.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpendD.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtons(sender);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dtpstartD.Enabled = true;
            dtpendD.Enabled = true;
            btnCustomOK.Visible = true;
            btnCustomOK.Enabled = true;
            SetDateMenuButtons(sender);
        }

        private void btnCustomOK_Click(object sender, EventArgs e)
        {

            LoadData();
        }
    }
}
