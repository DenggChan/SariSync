namespace InventoryProject
{
    partial class frmProductModule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPId = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI.WinForms.GunaControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPName = new Guna.UI.WinForms.GunaTextBox();
            this.txtQty = new Guna.UI.WinForms.GunaTextBox();
            this.txtPurPrice = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSellPrice = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbPCategory = new Guna.UI.WinForms.GunaComboBox();
            this.dtPickerPDate = new System.Windows.Forms.DateTimePicker();
            this.lblQtyError = new System.Windows.Forms.Label();
            this.lblPReq = new System.Windows.Forms.Label();
            this.lblSReq = new System.Windows.Forms.Label();
            this.lblNReq = new System.Windows.Forms.Label();
            this.lblQReq = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.lblPId);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 97);
            this.panel1.TabIndex = 0;
            // 
            // lblPId
            // 
            this.lblPId.AutoSize = true;
            this.lblPId.Location = new System.Drawing.Point(584, 60);
            this.lblPId.Name = "lblPId";
            this.lblPId.Size = new System.Drawing.Size(105, 28);
            this.lblPId.TabIndex = 38;
            this.lblPId.Text = "Product ID";
            this.lblPId.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CustomClick = true;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconSize = 15F;
            this.btnExit.Location = new System.Drawing.Point(710, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnExit.OnHoverIconColor = System.Drawing.Color.White;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 14;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Details";
            // 
            // txtPName
            // 
            this.txtPName.BackColor = System.Drawing.Color.Transparent;
            this.txtPName.BaseColor = System.Drawing.Color.White;
            this.txtPName.BorderColor = System.Drawing.Color.Silver;
            this.txtPName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPName.Location = new System.Drawing.Point(22, 123);
            this.txtPName.Name = "txtPName";
            this.txtPName.PasswordChar = '\0';
            this.txtPName.SelectedText = "";
            this.txtPName.Size = new System.Drawing.Size(333, 35);
            this.txtPName.TabIndex = 3;
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.Transparent;
            this.txtQty.BaseColor = System.Drawing.Color.White;
            this.txtQty.BorderColor = System.Drawing.Color.Silver;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQty.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQty.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQty.Location = new System.Drawing.Point(22, 183);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(141, 35);
            this.txtQty.TabIndex = 4;
            // 
            // txtPurPrice
            // 
            this.txtPurPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPurPrice.BaseColor = System.Drawing.Color.White;
            this.txtPurPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtPurPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPurPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPurPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPurPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurPrice.Location = new System.Drawing.Point(388, 123);
            this.txtPurPrice.Name = "txtPurPrice";
            this.txtPurPrice.PasswordChar = '\0';
            this.txtPurPrice.SelectedText = "";
            this.txtPurPrice.Size = new System.Drawing.Size(141, 35);
            this.txtPurPrice.TabIndex = 7;
            this.txtPurPrice.TextChanged += new System.EventHandler(this.txtPurPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Qty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Purchase Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Product Category:";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtSellPrice.BaseColor = System.Drawing.Color.White;
            this.txtSellPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSellPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSellPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSellPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSellPrice.Location = new System.Drawing.Point(570, 123);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.PasswordChar = '\0';
            this.txtSellPrice.SelectedText = "";
            this.txtSellPrice.Size = new System.Drawing.Size(151, 35);
            this.txtSellPrice.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Selling Price:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(493, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnUpdate.Size = new System.Drawing.Size(119, 34);
            this.btnUpdate.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btnUpdate.StateCommon.Back.Color2 = System.Drawing.Color.SkyBlue;
            this.btnUpdate.StateCommon.Back.ColorAngle = 45F;
            this.btnUpdate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.StateCommon.Border.ColorAngle = 45F;
            this.btnUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.StateCommon.Border.Rounding = 50;
            this.btnUpdate.StateCommon.Border.Width = 1;
            this.btnUpdate.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -20, -1, -20);
            this.btnUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.btnUpdate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.btnUpdate.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(618, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnClear.Size = new System.Drawing.Size(119, 34);
            this.btnClear.StateCommon.Back.Color1 = System.Drawing.Color.Tomato;
            this.btnClear.StateCommon.Back.Color2 = System.Drawing.Color.Tomato;
            this.btnClear.StateCommon.Back.ColorAngle = 45F;
            this.btnClear.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.StateCommon.Border.ColorAngle = 45F;
            this.btnClear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnClear.StateCommon.Border.Rounding = 50;
            this.btnClear.StateCommon.Border.Width = 1;
            this.btnClear.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -20, -1, -20);
            this.btnClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClear.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnClear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.btnClear.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.btnClear.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.TabIndex = 21;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(372, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSave.Size = new System.Drawing.Size(119, 34);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.MediumAquamarine;
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.MediumAquamarine;
            this.btnSave.StateCommon.Back.ColorAngle = 45F;
            this.btnSave.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.StateCommon.Border.ColorAngle = 45F;
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSave.StateCommon.Border.Rounding = 50;
            this.btnSave.StateCommon.Border.Width = 1;
            this.btnSave.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -20, -1, -20);
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.btnSave.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.btnSave.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.TabIndex = 20;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbPCategory
            // 
            this.cbPCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbPCategory.BaseColor = System.Drawing.Color.White;
            this.cbPCategory.BorderColor = System.Drawing.Color.Silver;
            this.cbPCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbPCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPCategory.ForeColor = System.Drawing.Color.Black;
            this.cbPCategory.FormattingEnabled = true;
            this.cbPCategory.Location = new System.Drawing.Point(388, 187);
            this.cbPCategory.Name = "cbPCategory";
            this.cbPCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbPCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbPCategory.Size = new System.Drawing.Size(333, 40);
            this.cbPCategory.TabIndex = 25;
            this.cbPCategory.SelectedIndexChanged += new System.EventHandler(this.cbPCategory_SelectedIndexChanged);
            // 
            // dtPickerPDate
            // 
            this.dtPickerPDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerPDate.Location = new System.Drawing.Point(22, 242);
            this.dtPickerPDate.Name = "dtPickerPDate";
            this.dtPickerPDate.Size = new System.Drawing.Size(333, 39);
            this.dtPickerPDate.TabIndex = 26;
            // 
            // lblQtyError
            // 
            this.lblQtyError.AutoSize = true;
            this.lblQtyError.ForeColor = System.Drawing.Color.Red;
            this.lblQtyError.Location = new System.Drawing.Point(64, 161);
            this.lblQtyError.Name = "lblQtyError";
            this.lblQtyError.Size = new System.Drawing.Size(0, 28);
            this.lblQtyError.TabIndex = 39;
            // 
            // lblPReq
            // 
            this.lblPReq.AutoSize = true;
            this.lblPReq.ForeColor = System.Drawing.Color.Red;
            this.lblPReq.Location = new System.Drawing.Point(383, 100);
            this.lblPReq.Name = "lblPReq";
            this.lblPReq.Size = new System.Drawing.Size(0, 28);
            this.lblPReq.TabIndex = 40;
            // 
            // lblSReq
            // 
            this.lblSReq.AutoSize = true;
            this.lblSReq.ForeColor = System.Drawing.Color.Red;
            this.lblSReq.Location = new System.Drawing.Point(565, 100);
            this.lblSReq.Name = "lblSReq";
            this.lblSReq.Size = new System.Drawing.Size(0, 28);
            this.lblSReq.TabIndex = 41;
            // 
            // lblNReq
            // 
            this.lblNReq.AutoSize = true;
            this.lblNReq.ForeColor = System.Drawing.Color.Red;
            this.lblNReq.Location = new System.Drawing.Point(12, 100);
            this.lblNReq.Name = "lblNReq";
            this.lblNReq.Size = new System.Drawing.Size(0, 28);
            this.lblNReq.TabIndex = 42;
            // 
            // lblQReq
            // 
            this.lblQReq.AutoSize = true;
            this.lblQReq.ForeColor = System.Drawing.Color.Red;
            this.lblQReq.Location = new System.Drawing.Point(12, 161);
            this.lblQReq.Name = "lblQReq";
            this.lblQReq.Size = new System.Drawing.Size(0, 28);
            this.lblQReq.TabIndex = 43;
            // 
            // frmProductModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(767, 302);
            this.Controls.Add(this.lblQReq);
            this.Controls.Add(this.lblNReq);
            this.Controls.Add(this.lblSReq);
            this.Controls.Add(this.lblPReq);
            this.Controls.Add(this.lblQtyError);
            this.Controls.Add(this.dtPickerPDate);
            this.Controls.Add(this.cbPCategory);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPurPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.panel1);
            this.Name = "frmProductModule";
            this.Text = "frmProductModule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaControlBox btnExit;
        public Guna.UI.WinForms.GunaTextBox txtPName;
        public Guna.UI.WinForms.GunaTextBox txtQty;
        public Guna.UI.WinForms.GunaTextBox txtPurPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public Guna.UI.WinForms.GunaTextBox txtSellPrice;
        private System.Windows.Forms.Label label7;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.DateTimePicker dtPickerPDate;
        public System.Windows.Forms.Label lblPId;
        public System.Windows.Forms.Label lblQtyError;
        public System.Windows.Forms.Label lblPReq;
        public System.Windows.Forms.Label lblSReq;
        public System.Windows.Forms.Label lblNReq;
        public System.Windows.Forms.Label lblQReq;
        public Guna.UI.WinForms.GunaComboBox cbPCategory;
    }
}