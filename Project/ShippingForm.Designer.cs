namespace Project
{
    partial class ShippingForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.cartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersDBDataSet = new Project.UsersDBDataSet();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartTableAdapter = new Project.UsersDBDataSetTableAdapters.CartTableAdapter();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbCities = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lblConShip = new System.Windows.Forms.Label();
            this.GBdelivery = new System.Windows.Forms.GroupBox();
            this.rbJE = new System.Windows.Forms.RadioButton();
            this.rbPickup = new System.Windows.Forms.RadioButton();
            this.btnPay = new System.Windows.Forms.Button();
            this.cbTerms = new System.Windows.Forms.CheckBox();
            this.cbPrivacy = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.GBdelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(37, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 20;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblExit.Location = new System.Drawing.Point(771, 71);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(44, 21);
            this.lblExit.TabIndex = 40;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblShipping.Location = new System.Drawing.Point(349, 129);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(150, 36);
            this.lblShipping.TabIndex = 47;
            this.lblShipping.Text = "Shipping";
            // 
            // cartBindingSource1
            // 
            this.cartBindingSource1.DataMember = "Cart";
            this.cartBindingSource1.DataSource = this.usersDBDataSet;
            // 
            // usersDBDataSet
            // 
            this.usersDBDataSet.DataSetName = "UsersDBDataSet";
            this.usersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "Cart";
            this.cartBindingSource.DataSource = this.usersDBDataSet;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.usersDBDataSet;
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFirstName.Location = new System.Drawing.Point(145, 245);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 24);
            this.lblFirstName.TabIndex = 48;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(257, 244);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(158, 28);
            this.txtFirstName.TabIndex = 49;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(544, 245);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(158, 28);
            this.txtLastName.TabIndex = 51;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLastName.Location = new System.Drawing.Point(432, 246);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(102, 24);
            this.lblLastName.TabIndex = 50;
            this.lblLastName.Text = "Last Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCity.Location = new System.Drawing.Point(208, 292);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 24);
            this.lblCity.TabIndex = 52;
            this.lblCity.Text = "City";
            // 
            // cbCities
            // 
            this.cbCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCities.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCities.FormattingEnabled = true;
            this.cbCities.Items.AddRange(new object[] {
            "Amman",
            "Irbid",
            "Ajlun",
            "Jarash",
            "Mafraq",
            "Zarqa",
            "Al-Salt",
            "Ma\'an",
            "Tafilah",
            "Karak",
            "Aqaba",
            "Madaba"});
            this.cbCities.Location = new System.Drawing.Point(257, 291);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(158, 29);
            this.cbCities.TabIndex = 53;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAddress.Location = new System.Drawing.Point(460, 292);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 24);
            this.lblAddress.TabIndex = 54;
            this.lblAddress.Text = "Address";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(544, 292);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(158, 28);
            this.txtaddress.TabIndex = 55;
            // 
            // lblConShip
            // 
            this.lblConShip.AutoSize = true;
            this.lblConShip.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConShip.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblConShip.Location = new System.Drawing.Point(102, 189);
            this.lblConShip.Name = "lblConShip";
            this.lblConShip.Size = new System.Drawing.Size(285, 31);
            this.lblConShip.TabIndex = 56;
            this.lblConShip.Text = "Delivery Information";
            // 
            // GBdelivery
            // 
            this.GBdelivery.Controls.Add(this.rbJE);
            this.GBdelivery.Controls.Add(this.rbPickup);
            this.GBdelivery.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBdelivery.ForeColor = System.Drawing.Color.DarkOrange;
            this.GBdelivery.Location = new System.Drawing.Point(95, 343);
            this.GBdelivery.Name = "GBdelivery";
            this.GBdelivery.Size = new System.Drawing.Size(639, 100);
            this.GBdelivery.TabIndex = 58;
            this.GBdelivery.TabStop = false;
            this.GBdelivery.Text = "Delivery Options";
            // 
            // rbJE
            // 
            this.rbJE.AutoSize = true;
            this.rbJE.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJE.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbJE.Location = new System.Drawing.Point(240, 48);
            this.rbJE.Name = "rbJE";
            this.rbJE.Size = new System.Drawing.Size(376, 28);
            this.rbJE.TabIndex = 1;
            this.rbJE.Text = "Jordan Express (3 JOD - 5 business days)";
            this.rbJE.UseVisualStyleBackColor = true;
            // 
            // rbPickup
            // 
            this.rbPickup.AutoSize = true;
            this.rbPickup.Checked = true;
            this.rbPickup.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPickup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbPickup.Location = new System.Drawing.Point(54, 48);
            this.rbPickup.Name = "rbPickup";
            this.rbPickup.Size = new System.Drawing.Size(167, 28);
            this.rbPickup.TabIndex = 0;
            this.rbPickup.TabStop = true;
            this.rbPickup.Text = "PickUp (0 JOD)";
            this.rbPickup.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPay.Location = new System.Drawing.Point(322, 522);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(203, 47);
            this.btnPay.TabIndex = 59;
            this.btnPay.Text = "Continue to payment";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // cbTerms
            // 
            this.cbTerms.AutoSize = true;
            this.cbTerms.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTerms.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbTerms.Location = new System.Drawing.Point(298, 456);
            this.cbTerms.Name = "cbTerms";
            this.cbTerms.Size = new System.Drawing.Size(251, 22);
            this.cbTerms.TabIndex = 60;
            this.cbTerms.Text = "I accept the Terms and Conditions";
            this.cbTerms.UseVisualStyleBackColor = true;
            // 
            // cbPrivacy
            // 
            this.cbPrivacy.AutoSize = true;
            this.cbPrivacy.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrivacy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbPrivacy.Location = new System.Drawing.Point(298, 484);
            this.cbPrivacy.Name = "cbPrivacy";
            this.cbPrivacy.Size = new System.Drawing.Size(215, 22);
            this.cbPrivacy.TabIndex = 61;
            this.cbPrivacy.Text = "I agree on the Privacy Policy";
            this.cbPrivacy.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Project.Properties.Resources.logo;
            this.pictureBox5.Location = new System.Drawing.Point(39, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(101, 83);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project.Properties.Resources.Exit11;
            this.pictureBox4.Location = new System.Drawing.Point(734, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.line1;
            this.pictureBox1.Location = new System.Drawing.Point(-34, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(892, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // ShippingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 583);
            this.Controls.Add(this.cbPrivacy);
            this.Controls.Add(this.cbTerms);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.GBdelivery);
            this.Controls.Add(this.lblConShip);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.cbCities);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Name = "ShippingForm";
            this.Text = "Shipping";
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.GBdelivery.ResumeLayout(false);
            this.GBdelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblShipping;
        private UsersDBDataSet usersDBDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private System.Windows.Forms.BindingSource cartBindingSource1;
        private UsersDBDataSetTableAdapters.CartTableAdapter cartTableAdapter;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cbCities;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblConShip;
        private System.Windows.Forms.GroupBox GBdelivery;
        private System.Windows.Forms.RadioButton rbJE;
        private System.Windows.Forms.RadioButton rbPickup;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.CheckBox cbTerms;
        private System.Windows.Forms.CheckBox cbPrivacy;
    }
}

