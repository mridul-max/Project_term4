using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class OrderingScreen : Form
    {

        List<OrderingRow> currentOrderItems;
        List<OrderingRow> allOrderItems;
        OrderingConfirmation confirmControll;
        Table CurrentTable;
        Dictionary<string, Dictionary<string, List<ChapeauModel.MenuItem>>> menu;
        Font headerFont;
        Font subHeaderFont;

        //Constructor
        public OrderingScreen(Table table)
        {
            InitializeComponent();
            MenuItemService service = new MenuItemService();
            CurrentTable = table;
            menu = service.GetSortedMenu();
            currentOrderItems = new List<OrderingRow>();
            allOrderItems = new List<OrderingRow>();
            headerFont = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            subHeaderFont = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
        }

        private void OrderingScreen_Load(object sender, EventArgs e)
        {
            tabMenu.MakeTransparent();
            lblTableNr.Text = "Table: " + CurrentTable.TableNumber;
            FillAllItemsPanel();
            FillCurrentItemsPanel();
        }        
         
        /// <summary>
        /// Fills all the panels with menu items
        /// </summary>
        void FillAllItemsPanel()
        {
            FlowLayoutPanel panel = null;
            foreach (var categoryType in menu)
            {
                // select the correct panel
                if (categoryType.Key == "Drinks")
                {
                    panel = flpDrinkItems;
                }
                else if(categoryType.Key == "Dinner")
                {
                    panel = flpDinnerItems;
                }
                else if(categoryType.Key == "Lunch")
                {
                    panel = flpLunchItems;
                }

                //add header for the category
                panel.Controls.Add(NewLabel(categoryType.Key, headerFont));

                //loop over all the items in the category
                foreach (var category in categoryType.Value)
                {
                    // add header for the sub category
                    panel.Controls.Add(NewLabel(category.Key, subHeaderFont));

                    //loop over all the items in the sub category 
                    foreach (var menuItem in category.Value)
                    {
                        //add the usecontroll with the menu item info
                        OrderingRow row = new OrderingRow(this, menuItem);
                        panel.Controls.Add(row);
                        allOrderItems.Add(row);
                    }
                }
            }
        }

        /// <summary>
        /// Adds header and confirmation user controll to the current order panel
        /// </summary>
        void FillCurrentItemsPanel()
        {
            flpCurrentOrderItems.Controls.Add(NewLabel("Current Order", headerFont));
            confirmControll = new OrderingConfirmation(this);
            flpCurrentOrderItems.Controls.Add(confirmControll);
        }

        /// <summary>
        /// Updates the amount of the given orderRow in both the current order panel and the menu
        /// </summary>
        /// <param name="orderingRow">row to update the amount of</param>
        public void UpdateCurrentOrderItem(OrderingRow orderingRow)
        {
            //if the item is not yet in the current order panel, add it
            if (!ContainsMenuItem(currentOrderItems, orderingRow.OrderItem.MenuItem))
            {                
                orderingRow = new OrderingRow(this, orderingRow.OrderItem.MenuItem, orderingRow.Amount);
                currentOrderItems.Add(orderingRow);

                //add the order item row but keep the confirmation usercontroll at the bottom
                flpCurrentOrderItems.Controls.Remove(confirmControll);
                flpCurrentOrderItems.Controls.Add(orderingRow);
                flpCurrentOrderItems.Controls.Add(confirmControll);
            }
            else 
            {
                //loop over the rows in the menu
                foreach (var row in allOrderItems)
                {
                    //if the menuitem is the same update the ammount
                    if (orderingRow.OrderItem.MenuItem == row.OrderItem.MenuItem)
                    {
                        row.Amount = orderingRow.Amount;
                        break;
                    }
                }

                //loop over the rows in the current order panel
                foreach (var row in currentOrderItems)
                {
                    //if the menuitem is the same update the ammount
                    if (orderingRow.OrderItem.MenuItem == row.OrderItem.MenuItem)
                    {
                        row.Amount = orderingRow.Amount;
                        break;
                    }
                }

                // if the new amount is 0, remove the row from the current order panel
                if (orderingRow.Amount == 0)
                {
                    //get the correct row in the current panel
                    OrderingRow row = FindMenuItem(currentOrderItems, orderingRow.OrderItem.MenuItem);
                    currentOrderItems.Remove(row);
                    flpCurrentOrderItems.Controls.Remove(row);
                }
            }
        }

        /// <summary>
        /// Checks if the given menuitem is in the given list
        /// </summary>
        bool ContainsMenuItem(List<OrderingRow> rows, ChapeauModel.MenuItem menuItem)
        {
            foreach (var row in rows)
            {
                if (menuItem == row.OrderItem.MenuItem)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Finds the ordering row with the given menuitem in the given list
        /// </summary>
        OrderingRow FindMenuItem(List<OrderingRow> rows, ChapeauModel.MenuItem menuItem)
        {
            foreach (var row in rows)
            {
                if (menuItem == row.OrderItem.MenuItem)
                {
                    return row;
                }
            }
            return null;
        }

        /// <summary>
        /// Returns a new label with the given font and text
        /// </summary>
        Label NewLabel(string text, Font font)
        {
            Label label = new Label();
            label.Font = font;
            label.Text = text;
            label.AutoSize = true;

            return label;
        }

        /// <summary>
        /// Returns an Order with all the items in the current order panel
        /// </summary>
        public Order GetCurrentOrder()
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (OrderingRow row in currentOrderItems)
            {
                orderItems.Add(row.OrderItem);
            }
            Order currentOrder = new Order(CurrentTable.TableNumber, orderItems, Session.Instance.LoggedEmployee);
            return currentOrder;
        }
    }
}
