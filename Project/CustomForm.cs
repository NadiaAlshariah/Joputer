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
    public partial class CustomForm : Form
    {
        public CustomForm()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomForm_Load(object sender, EventArgs e)
        {
            lblTotalCalc.Text = "0 JOD";
            lblLogin.Text = LoginForm.Logged;
            lblOrderedItems.Text = CartForm.Items_counter();

            CBMotherboard.SelectedIndex = 0;
            CBCPU.SelectedIndex = 0;
            cbRAMs.SelectedIndex = 0;
            CBGPU.SelectedIndex = 0;
            CBcase.SelectedIndex = 0;
            CBmonitor.SelectedIndex = 0;
            CBMouse.SelectedIndex = 0;
            CBKeyboard.SelectedIndex = 0;
            CBAudio.SelectedIndex = 0;
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

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            

            lbItems.Items.Clear();

            lbItems.Items.Add(CBMotherboard.SelectedItem);
            lbItems.Items.Add(CBCPU.SelectedItem);
            lbItems.Items.Add(cbRAMs.SelectedItem);
            lbItems.Items.Add(CBGPU.SelectedItem);
            lbItems.Items.Add(CBcase.SelectedItem);
            lbItems.Items.Add(CBmonitor.SelectedItem);
            lbItems.Items.Add(CBKeyboard.SelectedItem);
            lbItems.Items.Add(CBMouse.SelectedItem);
            lbItems.Items.Add(CBAudio.SelectedItem);

            for (int i = 8; i >= 0; i -= 1)
            {
                if (lbItems.Items[i].ToString() == "None")
                {
                    lbItems.Items.Remove("None");
                }
            }

            Custom_Total();
            
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            
            if(lbItems.SelectedIndex >= 0)
            {
                lbItems.Items.RemoveAt(lbItems.SelectedIndex);
                Custom_Total();
               
            }
            else
            {
                MessageBox.Show("No item is selected");
            }
         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
            Custom_Total();
        }

        private void Custom_Total()
        {
            if (lbItems.Items.Count > 0)
            {
                string id_name;
                UsersDBDataSetTableAdapters.ItemsTableAdapter itemsTA = new UsersDBDataSetTableAdapters.ItemsTableAdapter();

                for (int counter = lbItems.Items.Count - 1; counter >= 0; counter -= 1)
                {
                    id_name = lbItems.Items[counter].ToString();
                    itemsTA.Check(id_name);
                }
                double total = itemsTA.PriceSum().Value;
                lblTotalCalc.Text = total.ToString()+" JOD";

                itemsTA.UnCheck();
            }
            else
            {
                lblTotalCalc.Text = "0 JOD";
            }
            
        }
        
        private string price_of(string item_id)
        {
            if (item_id == "None")
                return ("0");
            else
            {
                UsersDBDataSetTableAdapters.ItemsTableAdapter itemsTA = new UsersDBDataSetTableAdapters.ItemsTableAdapter();
                return (itemsTA.getPrice(item_id).ToString());
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (LoginForm.Logged == "Log in")
                MessageBox.Show("Please, Login first");
            else
            {
                foreach (string id in lbItems.Items)
                {
                    LaptopForm.AddToCart(id, price_of(id));
                    lblOrderedItems.Text = CartForm.Items_counter(); 
                }
            }
            CartForm cart = new CartForm();
            this.Hide();
            cart.ShowDialog();
        }

        private void CBMotherboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMBprice.Text = price_of(CBMotherboard.SelectedItem.ToString())+" JOD";
        }

        private void CBCPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCPUprice.Text = price_of(CBCPU.SelectedItem.ToString()) + " JOD";
        }

        private void cbRAMs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRAMprice.Text = price_of(cbRAMs.SelectedItem.ToString()) + " JOD";
        }

        private void CBGPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGPUprice.Text = price_of(CBGPU.SelectedItem.ToString()) + " JOD";
        }

        private void CBcase_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCasePrice.Text = price_of(CBcase.SelectedItem.ToString()) + " JOD";
        }

        private void CBmonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMonPrice.Text = price_of(CBmonitor.SelectedItem.ToString()) + " JOD";
        }

        private void CBKeyboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKeyPrice.Text = price_of(CBKeyboard.SelectedItem.ToString()) + " JOD";
        }

        private void CBMouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMousePrice.Text = price_of(CBMouse.SelectedItem.ToString()) + " JOD";
        }

        private void CBAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAudioPrice.Text = price_of(CBAudio.SelectedItem.ToString()) + " JOD";
        }
    }
}
