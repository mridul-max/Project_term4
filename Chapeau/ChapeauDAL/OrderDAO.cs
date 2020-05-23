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
                    Tip = dr["Tip"] == DBNull.Value ? 0 : float.Parse(dr["Tip"].ToString())
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
            Order order = null;

            if (reader.Read())
            {
                order = ReadOrder(reader);
                order.OrderItems = GetUnfinishedOrdersOfTable(id);
            }
                        
            reader.Close();
            conn.Close();
            return order;
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
        public int CreateOrder(int tableNumber, int employeeID)
        {
            string query = "INSERT INTO [Order](TableNumber, EmployeeID, isFinished) VALUES(@TableNumber, @EmployeeID, 0) SELECT SCOPE_IDENTITY(); ";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@TableNumber", tableNumber),
                new SqlParameter("@EmployeeID", employeeID)
            };
            return ExecuteEditQueryAutoIncrement(query, sqlParameters);
        }

        public void CreateOrderItems(int orderID, List<OrderItem> orderItems)
        {
            if (orderItems.Count < 1)
                return;
            string query = "INSERT INTO [OrderItem](OrderID, MenuItemID, OrderStateKey, Amount, LastStateChanged, OrderDateTime) VALUES";
            SqlParameter[] sqlParameters = new SqlParameter[2 * orderItems.Count + 2];
            sqlParameters[0] = new SqlParameter("@orderID", orderID);
            sqlParameters[1] = new SqlParameter("@date", DateTime.Now);
            for (int i = 0; i < orderItems.Count; i++)
            {
                query += $" (@orderID, @menuItemID{i}, 'PR', @amount{i}, @date, @date),";

                sqlParameters[ (i * 2) + 2 ] = new SqlParameter("@menuItemID" + i, orderItems[i].MenuItem.ID);
                sqlParameters[ (i * 2) + 3 ] = new SqlParameter("@amount" + i, orderItems[i].Amount);
            }
            query = query.Remove(query.Length - 1);

            ExecuteEditQuery(query, sqlParameters);
        }

        private Order ReadOrder(SqlDataReader reader)
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
                Tip =reader["Tip"]==DBNull.Value? 0: float.Parse(reader["Tip"].ToString())
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
        //Get all food for kitchen view
        public List<OrderItem> GetListOfFood(int OrderID)
        {
            OpenConnection();
            string query = "Select M.*,O.* From[OrderItem] as O Inner join MenuItem as M On M.MenuItemID = O.MenuItemID Inner join Category as C On M.CategoryID = C.CategoryID Where C.CategoryType != 'Drinks' And O.OrderID = @ID Order by O.OrderID,M.ItemName";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@Id",OrderID)
            };
            return ReadAllFood(ExecuteSelectQuery(query, sqlParameters));

        }
        //Reading all food for kitchen view
        private List<OrderItem> ReadAllFood(DataTable dataTable)
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
                    Category = dr["CategoryID"].ToString()
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
        //get all drinks order for bar view
        public List<OrderItem> GetAllDrinks(int OrderID)
        {
            OpenConnection();
            string query = "Select M.*,O.* From[OrderItem] as O Inner join MenuItem as M On M.MenuItemID = O.MenuItemID Inner join Category as C On M.CategoryID = C.CategoryID Where C.CategoryType = 'Drinks' And O.OrderID = @ID Order by O.OrderID,M.ItemName";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@Id",OrderID)
            };
            return ReadAllDrinks(ExecuteSelectQuery(query, sqlParameters));
        }
        //reading all the drinks for bar view
        private List<OrderItem> ReadAllDrinks(DataTable dataTable)
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
                    Category = dr["CategoryID"].ToString()
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
        //Ready to serve Orderitem 
        public void UpdateReadyItem(OrderItem items)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update OrderItem Set OrderStateKey = 'RD' Where id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", items.MenuItem);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }
        //Running to serve orderItem
        public void UpdateRunningItem(OrderItem items)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update OrderItem Set OrderStateKey = 'RN' Where id = @id;", conn);
            cmd.Parameters.AddWithValue("@Id",items.MenuItem);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }
        //preparing to serve orderItem
        public void UpdatePreparingItem(OrderItem items)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update OrderItem Set OrderStateKey = 'PR' Where id = @id;", conn);
            cmd.Parameters.AddWithValue("@Id", items.MenuItem);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }
    }
}