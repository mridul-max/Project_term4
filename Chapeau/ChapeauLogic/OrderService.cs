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
        public List<Order> GetAllUnfinishedOrders()
        {
            return orderDao.GetAllUnfinishedOrders();
        }
        public void SetOrderItemAsServed(OrderItem item)
        {
            orderDao.SetOrderItemAsServed(item);
        }
        public void UpdateReadyItem(OrderItem item)
        {
            orderDao.UpdateReadyItem(item);
        }
        public void UpdatePreparingItem(OrderItem item)
        {
            orderDao.UpdatePreparingItem(item);
        }
        public Order GetOrderByTableId(int id)
        {
            return orderDao.GetOrderByTableId(id);          
        }
        public OrderItem GetOrderItemsById(OrderItem item)
        {
            return orderDao.GetOrderItemById(item);
        }

        /// <summary>
        /// Create a new order in the database
        /// </summary>
        public void CreateNewOrder(Order order)
        {
            TableService tableService = new TableService();
            Order oldOrder = GetOrderByTableId(order.TableNr);
            if (oldOrder == null)
            {
                order.OrderID = orderDao.CreateOrder(order.TableNr, order.Host.EmployeeID);
            }
            else
            {
                order.OrderID = oldOrder.OrderID;
            }
            tableService.SetOccupied(order.TableNr);
            orderDao.CreateOrderItems(order.OrderID, order.OrderItems);
        }
        public List<OrderItem> GetAllRunningFood()
        {
            return orderDao.GetAllRunningFood();
        }
        public List<OrderItem> GetAllRunningDrinks()
        {
            return orderDao.GetAllRunningDrinks();
        }
        public int GetOrderTable(int OrderID)
        {
            return orderDao.GetOrderTable(OrderID);
        }

    }
}
