using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class LaptopForm : Form
    {
        
        public LaptopForm()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LaptopForm_Load(object sender, EventArgs e)
        {
            lblLogin.Text = LoginForm.Logged;
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void lblExit_Click_1(object sender, EventArgs e)
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AddToCart(label1.Text, label9.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        public static void AddToCart(string Name_lbl, string Price_lbl)
        {
            
            if (LoginForm.Logged == "Log in")
            {
                MessageBox.Show("Please log in first");
            }

            else if (LoginForm.Logged == "Admin")
            {
                MessageBox.Show("Admin accounts can't add items to cart");
            }

            else
            {
                UsersDBDataSetTableAdapters.CartTableAdapter cart = new UsersDBDataSetTableAdapters.CartTableAdapter();
                UsersDBDataSet.CartDataTable quantity = cart.InCart(Name_lbl, LoginForm.Logged);

                if (quantity.Rows.Count == 0)
                {
                    cart.InsertCart(Name_lbl, decimal.Parse(Price_lbl), LoginForm.Logged);
                    MessageBox.Show(Name_lbl + " is added to cart");
                }
                else
                {
                    UsersDBDataSet.CartDataTable valueTable = cart.returnQuantity(Name_lbl, LoginForm.Logged);
                    string New_Q = (int.Parse(valueTable.Rows[0][3].ToString()) +1).ToString();
                    string New_P = ((float.Parse(Price_lbl))*(float.Parse(New_Q))).ToString();
                    cart.QuantityAdd(short.Parse(New_Q), decimal.Parse(New_P) , Name_lbl, LoginForm.Logged);
                }

            }
            
        }

        

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AddToCart(label2.Text, label8.Text);
            lblOrderedItems.Text = CartForm.Items_counter();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AddToCart(label3.Text, label4.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            AddToCart(label13.Text, label12.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            AddToCart(label6.Text, label11.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            AddToCart(label7.Text, label10.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void lblCart_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm();
            this.Hide();
            cart.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm();
            this.Hide();
            cart.ShowDialog();
        }
    }
}
