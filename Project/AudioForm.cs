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
    public partial class AudioForm : Form
    {
        public AudioForm()
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

        private void AudioForm_Load(object sender, EventArgs e)
        {
            lblLogin.Text = LoginForm.Logged;
            lblOrderedItems.Text = CartForm.Items_counter();
            lbAccess.SelectedIndex = 2;
        }

        private void lbAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAccess.SelectedIndex == 1)
            {
                this.Hide();
                KeyboardForm keyboard = new KeyboardForm();
                keyboard.ShowDialog();

            }
            if (lbAccess.SelectedIndex == 0)
            {
                this.Hide();
                AccsessForm mouse = new AccsessForm();
                mouse.ShowDialog();
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pbStorage_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

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
            LaptopForm.AddToCart(label15.Text, label10.Text);
            lblOrderedItems.Text = CartForm.Items_counter();
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
