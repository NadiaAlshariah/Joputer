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
    public partial class LoginForm : Form
    {
        public LoginForm()
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public static string Logged = "Log in";

        private void button1_Click(object sender, EventArgs e)
        {
            //try
           // {
                UsersDBDataSetTableAdapters.loginTableAdapter user = new UsersDBDataSetTableAdapters.loginTableAdapter();
                UsersDBDataSet.loginDataTable dt = user.GetDataBy(txtUsername.Text, txtPassword.Text);
                UsersDBDataSet.loginDataTable admins = user.isAdmin(txtUsername.Text);

                if (admins.Rows.Count == 1)
                {
                    Logged = "Admin";
                }
                else
                {
                    Logged = txtUsername.Text;
                }

                if(dt.Rows.Count == 1)
                {
                   this.Hide();
                   HomePage home = new HomePage();
                   home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }

                txtPassword.Text = "";
                txtUsername.Text = "";
           // }
            //catch (Exception e2)
            {
               // MessageBox.Show("Error " + e2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccount acc = new CreateAccount();
            this.Hide();
            acc.ShowDialog();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }
    }
}
