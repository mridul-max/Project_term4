using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public int OrderID;
        public int TableNr;
        public List<OrderItem> OrderItems;
        public Employee Host;

        public float TotalPrice
        {
            get
            {
                float totalPrice = 0;
                foreach (OrderItem item in OrderItems)
                {
                    totalPrice += item.MenuItem.Price;
                }
                return totalPrice;
            }
        }

        public float TotalPriceWithVAT
        {
            get
            {
                float totalPrice = 0;
                foreach (OrderItem item in OrderItems)
                {
                    totalPrice += item.MenuItem.PriceWithVAT;
                }
                return totalPrice;
            }
        }

        public float TotalVAT
        {
            get
            {
                float totalPrice = 0;
                foreach (OrderItem item in OrderItems)
                {
                    totalPrice += item.MenuItem.Price * item.MenuItem.VAT;
                }
                return totalPrice;
            }
        }

    }
}
