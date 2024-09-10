namespace InventoryProject
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnMin = new Guna.UI.WinForms.GunaControlBox();
            this.btnExit = new Guna.UI.WinForms.GunaControlBox();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lblClock2 = new System.Windows.Forms.Label();
            this.lblClock1 = new System.Windows.Forms.Label();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUsers = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSales = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCustomers = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCategories = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProducts = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnHome = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.AnimationHoverSpeed = 0.07F;
            this.btnMin.AnimationSpeed = 0.03F;
            this.btnMin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMin.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMin.IconColor = System.Drawing.Color.Black;
            this.btnMin.IconSize = 15F;
            this.btnMin.Location = new System.Drawing.Point(1354, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnMin.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMin.OnPressedColor = System.Drawing.Color.Black;
            this.btnMin.Size = new System.Drawing.Size(45, 29);
            this.btnMin.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.CustomClick = true;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconSize = 15F;
            this.btnExit.Location = new System.Drawing.Point(1422, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnExit.OnHoverIconColor = System.Drawing.Color.White;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.centerPanel.Controls.Add(this.pictureBox1);
            this.centerPanel.Location = new System.Drawing.Point(316, 49);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1184, 792);
            this.centerPanel.TabIndex = 4;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.centerPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryProject.Properties.Resources.Untitled_design__2_;
            this.pictureBox1.Location = new System.Drawing.Point(336, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.kryptonButton2);
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.btnSales);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnCategories);
            this.panel2.Controls.Add(this.btnProducts);
            this.panel2.Controls.Add(this.kryptonButton1);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 873);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.gunaCirclePictureBox2);
            this.panel3.Controls.Add(this.lblClock2);
            this.panel3.Controls.Add(this.lblClock1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 792);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 81);
            this.panel3.TabIndex = 15;
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.Image = global::InventoryProject.Properties.Resources.clock_five;
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(246, 22);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(37, 33);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox2.TabIndex = 2;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // lblClock2
            // 
            this.lblClock2.AutoSize = true;
            this.lblClock2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock2.Location = new System.Drawing.Point(30, 17);
            this.lblClock2.Name = "lblClock2";
            this.lblClock2.Size = new System.Drawing.Size(66, 32);
            this.lblClock2.TabIndex = 1;
            this.lblClock2.Text = "Date";
            // 
            // lblClock1
            // 
            this.lblClock1.AutoSize = true;
            this.lblClock1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock1.Location = new System.Drawing.Point(30, 40);
            this.lblClock1.Name = "lblClock1";
            this.lblClock1.Size = new System.Drawing.Size(67, 32);
            this.lblClock1.TabIndex = 0;
            this.lblClock1.Text = "Time";
            this.lblClock1.Click += new System.EventHandler(this.lblClock1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(0, 665);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton2.Size = new System.Drawing.Size(310, 74);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.kryptonButton2.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateCommon.Border.Rounding = 50;
            this.kryptonButton2.StateCommon.Border.Width = 1;
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonButton2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonButton2.TabIndex = 14;
            this.kryptonButton2.Values.Image = global::InventoryProject.Properties.Resources.receipt__1_;
            this.kryptonButton2.Values.Text = " Transaction Log";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(1, 585);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnUsers.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnUsers.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnUsers.Size = new System.Drawing.Size(310, 74);
            this.btnUsers.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnUsers.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnUsers.StateCommon.Back.ColorAngle = 45F;
            this.btnUsers.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnUsers.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnUsers.StateCommon.Border.ColorAngle = 45F;
            this.btnUsers.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUsers.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUsers.StateCommon.Border.Rounding = 50;
            this.btnUsers.StateCommon.Border.Width = 1;
            this.btnUsers.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUsers.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUsers.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUsers.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUsers.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUsers.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUsers.TabIndex = 11;
            this.btnUsers.Values.Image = global::InventoryProject.Properties.Resources.circle_user__1_;
            this.btnUsers.Values.Text = " Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(4, 505);
            this.btnSales.Name = "btnSales";
            this.btnSales.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnSales.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnSales.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSales.Size = new System.Drawing.Size(310, 74);
            this.btnSales.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnSales.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnSales.StateCommon.Back.ColorAngle = 45F;
            this.btnSales.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnSales.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnSales.StateCommon.Border.ColorAngle = 45F;
            this.btnSales.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSales.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSales.StateCommon.Border.Rounding = 50;
            this.btnSales.StateCommon.Border.Width = 1;
            this.btnSales.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSales.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSales.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSales.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSales.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSales.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSales.TabIndex = 10;
            this.btnSales.Values.Image = global::InventoryProject.Properties.Resources.basket_shopping_simple__1_;
            this.btnSales.Values.Text = " Sales";
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(5, 425);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnCustomers.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnCustomers.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCustomers.Size = new System.Drawing.Size(310, 74);
            this.btnCustomers.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnCustomers.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnCustomers.StateCommon.Back.ColorAngle = 45F;
            this.btnCustomers.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnCustomers.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnCustomers.StateCommon.Border.ColorAngle = 45F;
            this.btnCustomers.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCustomers.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCustomers.StateCommon.Border.Rounding = 50;
            this.btnCustomers.StateCommon.Border.Width = 1;
            this.btnCustomers.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCustomers.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCustomers.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustomers.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustomers.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCustomers.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCustomers.TabIndex = 9;
            this.btnCustomers.Values.Image = global::InventoryProject.Properties.Resources.review__1_;
            this.btnCustomers.Values.Text = " Customers";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(2, 265);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnCategories.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnCategories.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCategories.Size = new System.Drawing.Size(310, 74);
            this.btnCategories.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnCategories.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnCategories.StateCommon.Back.ColorAngle = 45F;
            this.btnCategories.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnCategories.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnCategories.StateCommon.Border.ColorAngle = 45F;
            this.btnCategories.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCategories.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCategories.StateCommon.Border.Rounding = 50;
            this.btnCategories.StateCommon.Border.Width = 1;
            this.btnCategories.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCategories.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCategories.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCategories.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCategories.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCategories.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCategories.TabIndex = 8;
            this.btnCategories.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.Values.Image")));
            this.btnCategories.Values.Text = " Categories";
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(5, 345);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnProducts.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnProducts.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnProducts.Size = new System.Drawing.Size(310, 74);
            this.btnProducts.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnProducts.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnProducts.StateCommon.Back.ColorAngle = 45F;
            this.btnProducts.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnProducts.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnProducts.StateCommon.Border.ColorAngle = 45F;
            this.btnProducts.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProducts.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnProducts.StateCommon.Border.Rounding = 50;
            this.btnProducts.StateCommon.Border.Width = 1;
            this.btnProducts.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProducts.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProducts.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnProducts.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnProducts.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProducts.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProducts.TabIndex = 7;
            this.btnProducts.Values.Image = global::InventoryProject.Properties.Resources.box_open__2_;
            this.btnProducts.Values.Text = " Products";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(3, 270);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(0, 0);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 50;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 5;
            this.kryptonButton1.Values.Text = "Home";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(4, 185);
            this.btnHome.Name = "btnHome";
            this.btnHome.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnHome.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnHome.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHome.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHome.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnHome.Size = new System.Drawing.Size(310, 74);
            this.btnHome.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnHome.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnHome.StateCommon.Back.ColorAngle = 45F;
            this.btnHome.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnHome.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(178)))));
            this.btnHome.StateCommon.Border.ColorAngle = 45F;
            this.btnHome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHome.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnHome.StateCommon.Border.Rounding = 50;
            this.btnHome.StateCommon.Border.Width = 1;
            this.btnHome.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHome.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHome.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnHome.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnHome.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnHome.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnHome.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHome.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnHome.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.btnHome.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHome.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHome.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHome.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHome.TabIndex = 4;
            this.btnHome.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Values.Image")));
            this.btnHome.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnHome.Values.Text = " Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.gunaCirclePictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 169);
            this.panel1.TabIndex = 13;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(137, 59);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(200, 54);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::InventoryProject.Properties.Resources.Untitled_design__1_;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(21, 29);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(110, 110);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1500, 873);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.btnMin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox btnMin;
        private Guna.UI.WinForms.GunaControlBox btnExit;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label lblUser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHome;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCustomers;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCategories;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProducts;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSales;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblClock1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private System.Windows.Forms.Label lblClock2;
        private System.Windows.Forms.Timer timer1;
    }
}