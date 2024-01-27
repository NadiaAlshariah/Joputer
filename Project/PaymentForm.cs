using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            txtName.Text = ShippingForm.CustomerName;
            txtName.Enabled = false;
            txtCardNum.Enabled = false;
            txtCVV.Enabled = false;
            expDate.Enabled = false;

            lblitemsTotal.Text = CartForm.total;
            lblShippingTotal.Text = ShippingForm.shippingFees;
            lblTotalNum.Text = (float.Parse(lblitemsTotal.Text) + float.Parse(lblShippingTotal.Text)).ToString();
            lblitemsTotal.Text += " JOD";
            lblShippingTotal.Text += " JOD";
            lblTotalNum.Text += " JOD";
        }

        private void rbCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCard.Checked)
            {
                txtName.Enabled = true;
                txtCardNum.Enabled = true;
                txtCVV.Enabled = true;
                expDate.Enabled = true;
            }
            else
            {
                txtName.Enabled = false;
                txtCardNum.Enabled = false;
                txtCVV.Enabled = false;
                expDate.Enabled = false;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            UsersDBDataSetTableAdapters.CartTableAdapter cart = new UsersDBDataSetTableAdapters.CartTableAdapter();
            cart.ClearCart(LoginForm.Logged);
            MessageBox.Show("Order has been placed, thank you!");
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }
    }
}