using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ComponentFactory.Krypton.Toolkit;

namespace InventoryProject
{
    public partial class frmMain : Sample
    {
        

        public static string LoggedInUsername { get; set; }

        public frmMain(string loggedInUsername)
        {
            InitializeComponent();
            LoggedInUsername = loggedInUsername;
        }


        public frmMain()
        {
            InitializeComponent();
            


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            

            lblUser_Click(sender, e);
            timer1.Start();
        }
     
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            lblUser.Text = LoggedInUsername;
        }
    

        private void centerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Create an instance of frmUser
            frmUser userForm = new frmUser();

            // Set the TopLevel property of frmUser to false to embed it in another container (centerPanel)
            userForm.TopLevel = false;

            // Call a method to set the centerPanel to the user state
            SetcenterPanel(userForm);
        }
        private void SetcenterPanel(Form userForm)
        {
            centerPanel.Controls.Clear();

            centerPanel.Controls.Add(userForm);

            userForm.Location = new Point((centerPanel.Width - userForm.Width) / 2, (centerPanel.Height - userForm.Height) / 2);

            userForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.TopLevel = false;
            SetcenterPanel(homeForm);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts productsForm = new frmProducts();
            productsForm.TopLevel = false;
            SetcenterPanel(productsForm);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers customersForm = new frmCustomers();
            customersForm.TopLevel = false;
            SetcenterPanel(customersForm);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmCategory categoryForm = new frmCategory();
            categoryForm.TopLevel = false;
            SetcenterPanel(categoryForm);

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales saleForm = new frmSales();
            saleForm.TopLevel = false;
            SetcenterPanel(saleForm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock1.Text = DateTime.Now.ToString("h:mm tt");
            lblClock2.Text = DateTime.Now.ToLongDateString();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            frmTransaction transactForm = new frmTransaction();

            // Set the owner of frmTransaction to the current form (frmMain)
            transactForm.Owner = this; // Assuming 'this' refers to an instance of frmMain

            transactForm.TopLevel = false;
            SetcenterPanel(transactForm);
        }

        private void lblClock1_Click(object sender, EventArgs e)
        {

        }
    }
}


