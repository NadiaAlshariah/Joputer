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
    public partial class ShippingForm : Form
    {
        public ShippingForm()
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
        static public string CustomerName = "";
        static public string shippingFees = "0";
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (rbJE.Checked)
                shippingFees = "3";


            if ((txtFirstName.Text.Length >= 3) && (txtLastName.Text.Length >= 3))
            {
                CustomerName += txtFirstName.Text + " " + txtLastName.Text;
                if (cbCities.SelectedIndex >= 0)
                {
                    if ((txtaddress.Text.Length >= 3))
                    {
                        if ((cbPrivacy.Checked) && (cbTerms.Checked))
                        {
                            this.Hide();
                            PaymentForm pay = new PaymentForm();
                            pay.ShowDialog();
                        }
                        else
                            MessageBox.Show("You have to agree on Terms and Privacy Policy");
                    }
                    else
                        MessageBox.Show("address should be longer than 3 characters");

                }
                else
                    MessageBox.Show("You should choose a city");

            }
            else
                MessageBox.Show("Names should be longer than 3 characters");
                      
        }
    }
}