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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }


        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CreateAccount_Load(object sender, EventArgs e)
        {
            lblOrderedItems.Text = CartForm.Items_counter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool passwordCheck = true;
            if (txtPassword.TextLength < 8)
            {
                MessageBox.Show("Passwords should be longer than 8 characters");
                passwordCheck = false;
            }
            if (txtConfirm.Text != txtPassword.Text)

            {
                MessageBox.Show("Password and Confirmation doesn't match");
                passwordCheck = false;
            }
            if (passwordCheck == false)
            {
                txtConfirm.Text = "";
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
            else
            {
                UsersDBDataSetTableAdapters.loginTableAdapter username = new UsersDBDataSetTableAdapters.loginTableAdapter();
                UsersDBDataSet.loginDataTable NameDT = username.userCheck(txtUsername.Text);
                if (NameDT.Rows.Count == 0)
                {
                    username.InsertQuery(txtUsername.Text, txtPassword.Text);
                    MessageBox.Show("Account registerd, please log in");
                    this.Hide();
                    LoginForm login = new LoginForm();
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username is taken");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirm.Text = "";
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
