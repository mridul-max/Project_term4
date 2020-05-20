using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderService
    {

        private OrderDAO orderDao = new OrderDAO();

        public List<OrderItem> GetUnfinishedOrdersOfTable(int TableNr)
        {
            return orderDao.GetUnfinishedOrdersOfTable(TableNr);
        }

        public void CompletePayment(Order payment)
        {
            orderDao.CompletePayment(payment);
        }

        public Order GetOrderByTableId(int id)
        {
            return orderDao.GetOrderByTableId(id);
          
        }

        public void CreatePayment(int tableNumber, int employeeID)
        {
            orderDao.CreatePayment(tableNumber, employeeID);
        }





    }
}
