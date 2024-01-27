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
    public partial class CartForm : Form
    {
        public static string total = "";
        public CartForm()
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
        string Total_Calc()
        {
            double total = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            
            return total.ToString() + " JOD";
        }

        public static string Items_counter()
        {
            if ((LoginForm.Logged == "Log in") || (LoginForm.Logged == "Admin"))
            {
                return ("(0)");
            }
            else
            {
                UsersDBDataSetTableAdapters.CartTableAdapter cart = new UsersDBDataSetTableAdapters.CartTableAdapter();
                if (cart.ItemsCounter(LoginForm.Logged)!=null)
                {
                    int counter = int.Parse(cart.ItemsCounter(LoginForm.Logged).ToString());
                    return ("(" + counter.ToString() + ")");
                }
                else
                {
                    return ("(0)");
                }
            } 
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                UsersDBDataSetTableAdapters.CartTableAdapter cart = new UsersDBDataSetTableAdapters.CartTableAdapter();
                string item_Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cart.DeleteRow(item_Name, LoginForm.Logged);
                UsersDBDataSet.CartDataTable UserCart = cart.ShowCart(LoginForm.Logged);
                dataGridView1.DataSource = UserCart;

                lblTotalCalc.Text = Total_Calc();
                lblOrderedItems.Text = Items_counter();
            }
            else
                MessageBox.Show("Cart is empty");
            
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                UsersDBDataSetTableAdapters.CartTableAdapter cart = new UsersDBDataSetTableAdapters.CartTableAdapter();
                cart.ClearCart(LoginForm.Logged);
                dataGridView1.DataSource = cart;
                lblOrderedItems.Text = "(0)";
                lblTotalCalc.Text = "0 JOD";
            }
            else
                MessageBox.Show("Cart is empty");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                total += Total_Calc().Replace("JOD", "");
                this.Hide();
                ShippingForm shipping = new ShippingForm();
                shipping.ShowDialog();
            }
            else
                MessageBox.Show("The Cart is Empty");
            
        }

        private void CartForm_Load_1(object sender, EventArgs e)
        {
            lblLogin.Text = LoginForm.Logged;
            // TODO: This line of code loads data into the 'usersDBDataSet.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.usersDBDataSet.Cart);

            UsersDBDataSetTableAdapters.CartTableAdapter cart = new UsersDBDataSetTableAdapters.CartTableAdapter();
            UsersDBDataSet.CartDataTable UserCart = cart.ShowCart(LoginForm.Logged);
            dataGridView1.DataSource = UserCart;

            double total = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }

            lblTotalCalc.Text = Total_Calc();
            lblOrderedItems.Text = Items_counter();
        }
    }
}