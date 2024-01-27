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
    public partial class HomePage : Form
    {

        
        public HomePage()
        {
            InitializeComponent();
        }

        private void pbLaptop_Click(object sender, EventArgs e)
        {
            this.Hide();
            LaptopForm laptop = new LaptopForm();
            laptop.ShowDialog();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbPc_Click(object sender, EventArgs e)
        {
            this.Hide();
            computerForm computer = new computerForm();
            computer.ShowDialog();
        }

        private void pbMonitor_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonitorForm monitor = new MonitorForm();
            monitor.ShowDialog();
        }

        private void pbSoft_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoftwareForm soft = new SoftwareForm();
            soft.ShowDialog();
        }

        private void pbHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            HardwareForm Hardware = new HardwareForm();
            Hardware.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblOrderedItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void lblCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void pbStorage_Click(object sender, EventArgs e)
        {
            this.Hide();
            storagForm storag = new storagForm();
            storag.ShowDialog();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            lblLogin.Text = LoginForm.Logged;
            lblOrderedItems.Text = CartForm.Items_counter();

        }

        private void pbCustom_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomForm custome = new CustomForm();
            custome.ShowDialog();
        }

        private void pbKey_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccsessForm accessories = new AccsessForm();
            accessories.ShowDialog();

        }
    }
}
