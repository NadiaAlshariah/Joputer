namespace Project
{
    partial class PaymentForm
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersDBDataSet = new Project.UsersDBDataSet();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartTableAdapter = new Project.UsersDBDataSetTableAdapters.CartTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.expDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblitems = new System.Windows.Forms.Label();
            this.lblitemsTotal = new System.Windows.Forms.Label();
            this.lblShippingTotal = new System.Windows.Forms.Label();
            this.lblshipping = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPayment.Location = new System.Drawing.Point(349, 123);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(148, 36);
            this.lblPayment.TabIndex = 47;
            this.lblPayment.Text = "Payment";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCard);
            this.groupBox1.Controls.Add(this.rbCash);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(213, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 88);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbCard.Location = new System.Drawing.Point(171, 40);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(191, 28);
            this.rbCard.TabIndex = 1;
            this.rbCard.Text = "Debt or Credit Card";
            this.rbCard.UseVisualStyleBackColor = true;
            this.rbCard.CheckedChanged += new System.EventHandler(this.rbCard_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbCash.Location = new System.Drawing.Point(67, 40);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(68, 28);
            this.rbCash.TabIndex = 0;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPay.Location = new System.Drawing.Point(322, 536);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(203, 47);
            this.btnPay.TabIndex = 60;
            this.btnPay.Text = "Complete Purchase";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtCardNum
            // 
            this.txtCardNum.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNum.Location = new System.Drawing.Point(355, 321);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(279, 28);
            this.txtCardNum.TabIndex = 62;
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCardNum.Location = new System.Drawing.Point(209, 322);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(123, 24);
            this.lblCardNum.TabIndex = 61;
            this.lblCardNum.Text = "Card Number";
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVV.Location = new System.Drawing.Point(542, 359);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(92, 28);
            this.txtCVV.TabIndex = 64;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCVV.Location = new System.Drawing.Point(487, 360);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(49, 24);
            this.lblCVV.TabIndex = 63;
            this.lblCVV.Text = "CVV";
            // 
            // expDate
            // 
            this.expDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.expDate.CustomFormat = "MM/yyyy";
            this.expDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expDate.Location = new System.Drawing.Point(363, 359);
            this.expDate.MinDate = new System.DateTime(2023, 1, 12, 0, 0, 0, 0);
            this.expDate.Name = "expDate";
            this.expDate.Size = new System.Drawing.Size(105, 28);
            this.expDate.TabIndex = 65;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDate.Location = new System.Drawing.Point(209, 360);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(148, 24);
            this.lblDate.TabIndex = 66;
            this.lblDate.Text = "Expiration Date";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(384, 283);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 28);
            this.txtName.TabIndex = 68;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(209, 284);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 24);
            this.lblName.TabIndex = 67;
            this.lblName.Text = "Card holder Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project.Properties.Resources.line1;
            this.pictureBox2.Location = new System.Drawing.Point(214, 393);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // lblitems
            // 
            this.lblitems.AutoSize = true;
            this.lblitems.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitems.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblitems.Location = new System.Drawing.Point(244, 416);
            this.lblitems.Name = "lblitems";
            this.lblitems.Size = new System.Drawing.Size(136, 21);
            this.lblitems.TabIndex = 70;
            this.lblitems.Text = "Items Ordered:";
            // 
            // lblitemsTotal
            // 
            this.lblitemsTotal.AutoSize = true;
            this.lblitemsTotal.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemsTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblitemsTotal.Location = new System.Drawing.Point(380, 416);
            this.lblitemsTotal.Name = "lblitemsTotal";
            this.lblitemsTotal.Size = new System.Drawing.Size(113, 21);
            this.lblitemsTotal.TabIndex = 71;
            this.lblitemsTotal.Text = "total of items";
            // 
            // lblShippingTotal
            // 
            this.lblShippingTotal.AutoSize = true;
            this.lblShippingTotal.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblShippingTotal.Location = new System.Drawing.Point(380, 440);
            this.lblShippingTotal.Name = "lblShippingTotal";
            this.lblShippingTotal.Size = new System.Drawing.Size(138, 21);
            this.lblShippingTotal.TabIndex = 73;
            this.lblShippingTotal.Text = "total of shipping";
            // 
            // lblshipping
            // 
            this.lblshipping.AutoSize = true;
            this.lblshipping.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshipping.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblshipping.Location = new System.Drawing.Point(244, 440);
            this.lblshipping.Name = "lblshipping";
            this.lblshipping.Size = new System.Drawing.Size(137, 21);
            this.lblshipping.TabIndex = 72;
            this.lblshipping.Text = "Shipping Fees:";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalNum.Location = new System.Drawing.Point(325, 492);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(113, 31);
            this.lblTotalNum.TabIndex = 75;
            this.lblTotalNum.Text = "TOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotal.Location = new System.Drawing.Point(243, 492);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 31);
            this.lblTotal.TabIndex = 74;
            this.lblTotal.Text = "Total:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project.Properties.Resources.line1;
            this.pictureBox3.Location = new System.Drawing.Point(213, 469);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 609);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblShippingTotal);
            this.Controls.Add(this.lblshipping);
            this.Controls.Add(this.lblitemsTotal);
            this.Controls.Add(this.lblitems);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.expDate);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.txtCardNum);
            this.Controls.Add(this.lblCardNum);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblPayment;
        private UsersDBDataSet usersDBDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private System.Windows.Forms.BindingSource cartBindingSource1;
        private UsersDBDataSetTableAdapters.CartTableAdapter cartTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.DateTimePicker expDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblitems;
        private System.Windows.Forms.Label lblitemsTotal;
        private System.Windows.Forms.Label lblShippingTotal;
        private System.Windows.Forms.Label lblshipping;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

