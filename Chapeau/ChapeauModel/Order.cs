using System;
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
        public Employee Host { get; set; }
        public PaymentMethod Method { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Comment { get; set; }
        public bool IsFinished { get; set; }

        public float Tip{ get; set; }

        public float TotalPrice
        {
            get
            {
                float totalPrice = 0;
                foreach (OrderItem item in OrderItems)
                {
                    totalPrice += item.MenuItem.Price*item.Amount;
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
                    totalPrice += item.MenuItem.PriceWithVAT*item.Amount;
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
                    totalPrice += item.MenuItem.Price * item.MenuItem.VAT*item.Amount;
                }
                return totalPrice;
            }
        }

        public Order() { }
        public Order(int TableNr, List<OrderItem> orderItems, Employee Host)
        {
            this.TableNr = TableNr;
            this.OrderItems = orderItems;
            this.Host = Host;
        }

    }
}
