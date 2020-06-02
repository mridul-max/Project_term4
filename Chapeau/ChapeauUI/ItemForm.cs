using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class ItemForm : Form
    {
        MenuItemService serviceItem = new MenuItemService();

        public ItemForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsError = false;  // if false apply changes.
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                IsError = true;
            }

            txtPrice.Text = txtPrice.Text.Replace('.', ',');
            if (String.IsNullOrWhiteSpace(txtPrice.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, @"^[0-9]*(?:\,[0-9]+)?$"))
            {
                IsError = true;
            }

            if (String.IsNullOrWhiteSpace(txtStock.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtStock.Text, "^[0-9]*$"))
            {
                IsError = true;
            }


            if (cmbCategory.SelectedIndex < 0)
            {
                IsError = true;
            }

            if (!IsError)
            {
                ChapeauModel.MenuItem item = new ChapeauModel.MenuItem()
                {
                    Name = txtName.Text,
                    Price = float.Parse(txtPrice.Text),
                    Stock = int.Parse(txtStock.Text),
                    Category = ConvertToCategory(cmbCategory.SelectedItem.ToString())
                };

                serviceItem.CreateMenuItem(item);
                MessageBox.Show("Item has been created", "Process complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill the fields properly", "Process incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string ConvertToCategory(string selectedCategory)
        {
            switch (selectedCategory)
            {
                case "Beers":
                    return "BD";
                case "Desserts":
                    return "DD";
                case "Mains":
                    return "DM";
                case "Starters":
                    return "DS";
                case "Hot drinks":
                    return "HD";
                case "Bites":
                    return "LB";
                case "Main":
                    return "LM";
                case "Special":
                    return "LS";
                case "Soft drinks":
                    return "SD";
                default:
                    return "WD";

            }
        }

        private void addMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAdd.Show();


            string[] Categories = new string[] { "Beers", "Desserts", "Mains", "Starters", "Hot drinks", "Bites", "Mains", "Special", "Soft drinks", "Wines" };
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(Categories);

        }

        private void returnToManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerScreen screen = new ManagerScreen();
            screen.ShowDialog();

        }          
        private void ItemForm_Load(object sender, EventArgs e)
        {

        }

        private void editMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
