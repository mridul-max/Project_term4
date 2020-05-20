using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;
using SomerenDAL;
using System.Collections.Generic;

namespace ChapeauDAL
{
    public class OrderDAO : Base
    {
        EmployeeDAO employeeDao = new EmployeeDAO();
        public OrderDAO() : base() { }

      
        public List<Order> GetAllPayments()
        {
            string query = "SELECT OrderID,TableNumber,EmployeeID,TotalPriceVAT,TotalPriceNoVAT,PaymentMethod,PaymentDateTime,Comment,isFinished,Tip FROM [Order]; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> payments = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order payment = new Order()
                {
                    OrderID = (int)dr["OrderID"],
                    TableNr = (int)dr["TableNumber"],
                    Host = employeeDao.GetById((int)dr["EmployeeID"]),
                    Method = dr["PaymentMethod"] == DBNull.Value ? PaymentMethod.Cash : (PaymentMethod)Enum.Parse(typeof(PaymentMethod), dr["PaymentMethod"].ToString()),
                    PaymentDate = dr["PaymentDateTime"] == DBNull.Value ? DateTime.Now : (DateTime)dr["PaymentDateTime"],
                    Comment = dr["Comment"] == DBNull.Value ? "  " : (string)dr["Comment"],
                    IsFinished = (bool)dr["isFinished"],
                    Tip = float.Parse(dr["Tip"].ToString())
                };
                payment.OrderItems = GetUnfinishedOrdersOfTable(payment.TableNr);
                payments.Add(payment);
            }
            return payments;
        }
        public Order GetOrderByTableId(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT OrderID,TableNumber,EmployeeID,TotalPriceVAT,TotalPriceNoVAT,PaymentMethod,PaymentDateTime,Comment,isFinished, Tip FROM [Order] WHERE TableNumber=@Id AND [Order].isFinished=0;", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            Order payment = null;

            if (reader.Read())
            {
                payment = ReadPayment(reader);
                payment.OrderItems = GetUnfinishedOrdersOfTable(id);
            }
                        
            reader.Close();
            conn.Close();
            return payment;
        }
        public void CompletePayment(Order payment)
        {

            OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE [Order] set TotalPriceNoVAT= @TotalPriceNoVat, TotalPriceVAT=@TotalPriceVat, PaymentMethod =@Method, PaymentDateTime= @Date,Comment=@Comment,Tip=@Tip ,isFinished= 1 where orderid=@ID;", conn);
            cmd.Parameters.AddWithValue("@TotalPriceNoVat", payment.TotalPrice);
            cmd.Parameters.AddWithValue("@TotalPriceVat", payment.TotalPriceWithVAT);
            cmd.Parameters.AddWithValue("@Method", payment.Method.ToString());
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.Parameters.AddWithValue("@Comment", payment.Comment);
            cmd.Parameters.AddWithValue("@ID", payment.OrderID);
            cmd.Parameters.AddWithValue("@Tip",payment.Tip);
            
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }
        public void CreatePayment(int tableNumber, int employeeID)
        {

            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO[order] VALUES(@TableNumber,@EmployeeID, NULL, NULL, NULL, NULL, NULL, 0, NULL); ", conn);
            cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }

        private Order ReadPayment(SqlDataReader reader)
        {

            Order payment = new Order()
            {
                OrderID = (int)reader["OrderID"],
                TableNr = (int)reader["TableNumber"],
                Host = employeeDao.GetById((int)reader["EmployeeID"]),
                Method = reader["PaymentMethod"]== DBNull.Value ?PaymentMethod.Cash:(PaymentMethod)Enum.Parse(typeof(PaymentMethod), reader["PaymentMethod"].ToString()),
                PaymentDate = reader["PaymentDateTime"]==DBNull.Value?DateTime.Now: (DateTime)reader["PaymentDateTime"],
                Comment = reader["Comment"]==DBNull.Value?"  ": (string)reader["Comment"],
                IsFinished = (bool)reader["isFinished"],
                Tip = float.Parse(reader["Tip"].ToString())
            };
            return payment;
        }
        public List<OrderItem> GetUnfinishedOrdersOfTable(int TableNr)
        {
            OpenConnection();
            string query = "SELECT MenuItem.*,Orderitem.Amount,OrderItem.OrderStateKey,OrderItem.LastStateChanged,Category.CategoryName,Category.VAT,Category.CategoryType,OrderState.OrderStateInformation FROM OrderItem INNER JOIN [Order] ON  [OrderItem].OrderID=[Order].OrderID INNER JOIN MenuItem ON OrderItem.MenuItemID = MenuItem.MenuItemID  INNER JOIN OrderState ON OrderState.OrderStateKey=OrderItem.OrderStateKey INNER JOIN Category ON Category.CategoryID = MenuItem.CategoryID WHERE [Order].TableNumber =@Id AND [Order].isFinished=0; ";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@Id",TableNr)
            };
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    Name = dr["ItemName"].ToString(),
                    Price = float.Parse(dr["Price"].ToString()),
                    Stock = (int)dr["Stock"],
                    Description = dr["Description"].ToString(),
                    CategoryType = (CategoryType)Enum.Parse(typeof(CategoryType), dr["CategoryType"].ToString()),
                    Category = dr["CategoryName"].ToString(),
                    VAT = ((int)dr["VAT"]) / 100f
                };

                OrderItem orderItem = new OrderItem()
                {
                    MenuItem = menuItem,
                    Amount = (int)dr["Amount"],
                    DateTimeAdded = (DateTime)dr["LastStateChanged"],
                    orderState = (OrderState)Enum.Parse(typeof(OrderState), dr["OrderStateInformation"].ToString()),
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }


    }
}
