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

            FillAllItemsPanel();
            FillCurrentItemsPanel();
        }

        void FillAllItemsPanel()
        {
            FlowLayoutPanel panel = null;
            foreach (var categoryType in menu)
            {
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

                panel.Controls.Add(NewLabel(categoryType.Key, headerFont));
                foreach (var category in categoryType.Value)
                {
                    panel.Controls.Add(NewLabel(category.Key, subHeaderFont));
                    foreach (var menuItem in category.Value)
                    {
                        OrderingRow row = new OrderingRow(this, menuItem);
                        panel.Controls.Add(row);
                        allOrderItems.Add(row);
                    }
                }
            }
        }

        void FillCurrentItemsPanel()
        {
            flpCurrentOrderItems.Controls.Add(NewLabel("Current Order", headerFont));
            confirmControll = new OrderingConfirmation(this);
            flpCurrentOrderItems.Controls.Add(confirmControll);
        }

        public void UpdateCurrentOrderItem(OrderingRow orderingRow)
        {
            if (!containsMenuItem(currentOrderItems, orderingRow.MenuItem))
            {                
                orderingRow = new OrderingRow(this, orderingRow.MenuItem, orderingRow.Amount);
                currentOrderItems.Add(orderingRow);
                flpCurrentOrderItems.Controls.Remove(confirmControll);
                flpCurrentOrderItems.Controls.Add(orderingRow);
                flpCurrentOrderItems.Controls.Add(confirmControll);
            }
            else 
            {

                foreach (var row in allOrderItems)
                {
                    if (orderingRow.MenuItem == row.MenuItem)
                    {
                        row.Amount = orderingRow.Amount;
                    }
                }

                foreach (var row in currentOrderItems)
                {
                    if (orderingRow.MenuItem == row.MenuItem)
                    {
                        row.Amount = orderingRow.Amount;
                    }
                }

                if (orderingRow.Amount == 0)
                {
                    currentOrderItems.Remove(orderingRow);
                    flpCurrentOrderItems.Controls.Remove(orderingRow);
                }
            }
        }

        bool containsMenuItem(List<OrderingRow> rows, ChapeauModel.MenuItem menuItem)
        {
            foreach (var row in rows)
            {
                if (menuItem == row.MenuItem)
                {
                    return true;
                }
            }
            return false;
        }

        Label NewLabel(string text, Font font)
        {
            Label label = new Label();
            label.Font = font;
            label.Text = text;
            label.AutoSize = true;

            return label;
        }
    }
}
