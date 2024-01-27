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
    public partial class storagForm : Form
    {
        public storagForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
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

        private void storagForm_Load(object sender, EventArgs e)
        {
            lblLogin.Text = LoginForm.Logged;
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label1.Text, label9.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label14.Text, label8.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label3.Text, label4.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label16.Text, label12.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label7.Text, label11.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label13.Text, label10.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }
    }
}
