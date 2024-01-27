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
    public partial class computerForm : Form
    {
        public computerForm()
        {
            InitializeComponent();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void computerForm_Load(object sender, EventArgs e)
        {
            lblLogin.Text = LoginForm.Logged;
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
            LaptopForm.AddToCart(label1.Text, label9.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label14.Text, label8.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label3.Text, label4.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label13.Text, label12.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label15.Text, label11.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label7.Text, label10.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
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
