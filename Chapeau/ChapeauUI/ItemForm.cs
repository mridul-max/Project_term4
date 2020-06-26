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

        private void Button1_Click(object sender, EventArgs e)
        {
            bool IsError = false;  // if false apply changes.
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                IsError = true;
            }

            //get's the id from combo box by splitting it.
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
                //Creating the menu item for dao class.
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

        private void AddMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAdd.Show();
            pnlEditMenu.Hide();


            string[] Categories = new string[] { "Beers", "Desserts", "Mains", "Starters", "Hot drinks", "Bites", "Mains", "Special", "Soft drinks", "Wines" };
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(Categories);

        }

        private void ReturnToManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerScreen screen = new ManagerScreen();
            screen.ShowDialog();

        }

        /// <summary>
        /// Window load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemForm_Load(object sender, EventArgs e)
        {

        }

        private void EditMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlEditMenu.Show();
            pnlAdd.Hide();

            List<ChapeauModel.MenuItem> AllItems = serviceItem.GetMenuItems();

            foreach (ChapeauModel.MenuItem item in AllItems)
            {
                ItemsGV.Rows.Add(item.ID, item.Name, item.CategoryType, item.Stock);
            }
        }

        /// <summary>
        /// Update MenuItem event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnApplyStock_Click(object sender, EventArgs e)
        {
            bool IsError = false;

            if (ItemsGV.SelectedRows.Count <= 0)
            {
                return;
            }

            if (IsError)
            {
                MessageBox.Show("Please fill the values properly", "Fields required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int selectedItemId = (int)ItemsGV.SelectedRows[0].Cells[0].Value;
                ChapeauModel.MenuItem menuItem = serviceItem.GetById(selectedItemId);
                menuItem.Stock = int.Parse(txtCount.Text);
                menuItem.Name = txtItemName.Text;
                serviceItem.UpdateStockOfItem(menuItem);
                txtCount.Text="";
                txtItemName.Text="";

                MessageBox.Show("Stock has been updated", "Stock updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Refresh GridView Data
                List<ChapeauModel.MenuItem> AllItems = serviceItem.GetMenuItems();
                ItemsGV.Rows.Clear();
                foreach (ChapeauModel.MenuItem item in AllItems)
                {
                    ItemsGV.Rows.Add(item.ID, item.Name, item.CategoryType, item.Stock);
                }

            }
        }


        private void ItemsGV_SelectionChanged(object sender, EventArgs e)
        {
            if (ItemsGV.SelectedRows.Count > 0)
            {
                var id = ItemsGV.SelectedRows[0].Cells[0].Value;
                txtCount.Text = ItemsGV.SelectedRows[0].Cells[3].Value.ToString();
                txtItemName.Text = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
