using System;

namespace ChapeauModel
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public MenuItem MenuItem { get; set; }
        public OrderState orderState { get; set; }
        public int Amount { get; set; }
        public DateTime DateTimeAdded { get; set; }

        public OrderItem() { }
        public OrderItem(MenuItem menuItem, int amount = 1)
        {       
            this.MenuItem = menuItem;
            this.Amount = amount;
            this.orderState = OrderState.PrepairingOrder;
            this.DateTimeAdded = DateTime.Now;
        }

        public override string ToString()
        {
            return MenuItem.Name;
        }
    }
}