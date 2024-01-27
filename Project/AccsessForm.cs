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
    public partial class AccsessForm : Form
    {
        public AccsessForm()
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

        private void AccsessForm_Load(object sender, EventArgs e)
        {
            lblLogin.Text = LoginForm.Logged;
            lbAccess.SelectedIndex = 0;
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void lbAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAccess.SelectedIndex == 1)
            {
                this.Hide();
                KeyboardForm keyboard = new KeyboardForm();
                keyboard.ShowDialog();

            }
            if (lbAccess.SelectedIndex == 2)
            {
                this.Hide();
                AudioForm Audio = new AudioForm();
                Audio.ShowDialog();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label1.Text, label9.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label2.Text, label8.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label3.Text, label4.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label13.Text, label12.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            LaptopForm.AddToCart(label6.Text, label11.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
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
