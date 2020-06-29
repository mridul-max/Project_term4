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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            txtPrice.Text = txtPrice.Text.Replace('.', ',');

            if (cmbCategory.SelectedIndex < 0 || String.IsNullOrWhiteSpace(txtName.Text) || String.IsNullOrWhiteSpace(txtStock.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtStock.Text, "^[0-9]*$") || String.IsNullOrWhiteSpace(txtPrice.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, @"^[0-9]*(?:\,[0-9]+)?$"))
            {
                MessageBox.Show("Please fill the fields properly", "Process incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            txtName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            cmbCategory.SelectedItem = null;
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
            pnlRemoveItem.Hide();


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
            EditMenuItemToolStripMenuItem_Click(sender, e);
        }

        private void EditMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlEditMenu.Show();
            pnlAdd.Hide();
            pnlRemoveItem.Hide();

            FillMenuItemListView(listEditMenu);
        }

        /// <summary>
        /// Update MenuItem event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnApplyStock_Click(object sender, EventArgs e)
        {

            if (listEditMenu.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a menu item", "Fields required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrWhiteSpace(txtItemName.Text) || String.IsNullOrWhiteSpace(txtCount.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtCount.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please fill the values properly", "Fields required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChapeauModel.MenuItem menuItem = (ChapeauModel.MenuItem)listEditMenu.SelectedItems[0].Tag;
            menuItem.Stock = int.Parse(txtCount.Text);
            menuItem.Name = txtItemName.Text;
            serviceItem.UpdateStockOfItem(menuItem);
            txtCount.Text = "";
            txtItemName.Text = "";

            MessageBox.Show("Stock has been updated", "Stock updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // refresh the listview
            FillMenuItemListView(listEditMenu);
        }
        private void FillMenuItemListView(ListView listView)
        {
            List<ChapeauModel.MenuItem> items = serviceItem.GetMenuItems();

            listView.Clear();
            listView.Columns.Add("Id");
            listView.Columns.Add("Item Name");
            listView.Columns.Add("Category");
            listView.Columns.Add("Stock");
            foreach (ChapeauModel.MenuItem menuItem in items)
            {
                ListViewItem item = new ListViewItem(
                    new string[] {
                    menuItem.ID.ToString(),
                    menuItem.Name,
                    menuItem.Category,
                    menuItem.Stock.ToString()
                });
                if (menuItem.Stock < 10)
                    item.ForeColor = Color.Red;
                else
                    item.ForeColor = Color.Black;
                item.Tag = menuItem;
                listView.Items.Add(item);

            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        //For removing an item.
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlAdd.Hide();
            pnlEditMenu.Hide();
            pnlRemoveItem.Show();

            FillMenuItemListView(listRemoveMenuItem);

        }
        //remove button
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (listRemoveMenuItem.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please pick a menu item to remove from system.", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //get's the id from combo box by splitting it.
                ChapeauModel.MenuItem ChosenMenuItem = (ChapeauModel.MenuItem)listRemoveMenuItem.SelectedItems[0].Tag;

                if (MessageBox.Show($"Are you sure you want to delete {ChosenMenuItem.Name} ", "Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    serviceItem.DeleteMenuItem(ChosenMenuItem);
                    MessageBox.Show("Employee has been removed.", "Employee removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillMenuItemListView(listRemoveMenuItem);
                }
            }
        }

        private void listEditMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEditMenu.SelectedItems.Count > 0)
            {
                ChapeauModel.MenuItem SelectedItem = (ChapeauModel.MenuItem)listEditMenu.SelectedItems[0].Tag;
                txtItemName.Text = SelectedItem.Name;
                txtCount.Text = SelectedItem.Stock.ToString();
            }
        }
    }
}
