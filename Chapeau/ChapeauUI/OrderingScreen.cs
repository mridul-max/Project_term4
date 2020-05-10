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
        List<OrderingRow> itemRows;
        public OrderingScreen()
        {
            InitializeComponent();
            MenuItemService service = new MenuItemService();
            Dictionary < string, Dictionary<string, List<ChapeauModel.MenuItem>>> menu = service.GetSortedMenu();
            itemRows = new List<OrderingRow>();
            Font headerFont = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            Font subHeaderFont = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);

            foreach (var categoryType in menu)
            {
                flowLayoutPanel1.Controls.Add(NewLabel("\n" + categoryType.Key, headerFont));
                foreach (var category in categoryType.Value)
                {
                    flowLayoutPanel1.Controls.Add(NewLabel(category.Key, subHeaderFont));
                    foreach (var menuItem in category.Value)
                    {
                        OrderingRow row = new OrderingRow(menuItem);
                        flowLayoutPanel1.Controls.Add(row);
                        itemRows.Add(row);
                    }
                }                
            }
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
