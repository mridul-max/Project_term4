using System;

namespace ChapeauModel
{
    public class OrderItem
    {
        public MenuItem MenuItem;
        public OrderState orderState;
        public int Amount;
        public DateTime DateTimeAdded;
    }
}
