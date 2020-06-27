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
                    Host =dr["EmployeeID"] ==DBNull.Value ? new Employee(): employeeDao.GetById((int)dr["EmployeeID"]),
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
        public List<Order>GetAllUnfinishedOrders()
        {
            string query = "SELECT OrderID,TableNumber,EmployeeID,TotalPriceVAT,TotalPriceNoVAT,PaymentMethod,PaymentDateTime,Comment,isFinished,Tip FROM [Order]WHERE [Order].isFinished=0 order by TableNumber; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
            UpdateOrderStates(payment.OrderID);
        }
        //YOU ARE HERE
        public OrderItem GetOrderItemById(OrderItem item)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Select *, MenuItem.*,OrderState.OrderStateInformation from OrderItem Inner join MenuItem ON MenuItem.MenuItemID=OrderItem.MenuItemID inner join OrderState on OrderState.OrderStateKey= Orderitem.OrderStateKey Where ID=@ID;", conn);
            cmd.Parameters.AddWithValue("@ID",item.OrderItemID);
            SqlDataReader reader = cmd.ExecuteReader();
            OrderItem orderItem = null;
            if(reader.Read())
            {
                orderItem = ReadOrderItem(reader);
            }
            reader.Close();
            conn.Close();
            return orderItem;
        }
        public void UpdateOrderStates(int orderID)
        {
            string query = "Update [OrderItem] SET [OrderStateKey]='OS' WHERE OrderID=@Id;";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@Id",orderID),
            };
            ExecuteEditQuery(query,sqlParameters);
          
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

        /// <summary>
        /// Creates the individual order items in the OrderItems Database Table
        /// </summary>
        public void CreateOrderItems(int orderID, List<OrderItem> orderItems)
        {
            if (orderItems.Count < 1)
                return;
            string query = "INSERT INTO [OrderItem](OrderID, MenuItemID, OrderStateKey, Amount, LastStateChanged, OrderDateTime) VALUES";
            SqlParameter[] sqlParameters = new SqlParameter[2 * orderItems.Count + 2];
            sqlParameters[0] = new SqlParameter("@orderID", orderID);
            sqlParameters[1] = new SqlParameter("@date", DateTime.Now);
            
            //loops over every order item and creates an insert value pair for it
            //then it subtracts the correct amount from the stock
            for (int i = 0; i < orderItems.Count; i++)
            {
                query += $" (@orderID, @menuItemID{i}, 'PR', @amount{i}, @date, @date),";

                sqlParameters[ (i * 2) + 2 ] = new SqlParameter("@menuItemID" + i, orderItems[i].MenuItem.ID);
                sqlParameters[ (i * 2) + 3 ] = new SqlParameter("@amount" + i, orderItems[i].Amount);

                AddStockForItem(orderItems[i].MenuItem.ID, -orderItems[i].Amount );
            }
            //remove the trailing comma
            query = query.Remove(query.Length - 1);

            ExecuteEditQuery(query, sqlParameters);
        }

        //changes the stock for the given item by the given amount
        private void AddStockForItem(int MenuItemID, int Amount)
        {
            string query = "UPDATE MenuItem SET Stock = Stock + @amount WHERE MenuItemID = @menuItemID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@amount", Amount);
            sqlParameters[1] = new SqlParameter("@menuItemID", MenuItemID);

            ExecuteEditQuery(query, sqlParameters);
        }

        private Order ReadOrder(SqlDataReader reader)
        {

            Order payment = new Order()
            {
                OrderID = (int)reader["OrderID"],
                TableNr = (int)reader["TableNumber"],
                Host = reader["EmployeeID"] == DBNull.Value ? new Employee() : employeeDao.GetById((int)reader["EmployeeID"]),
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
            string query = "SELECT MenuItem.*,OrderItem.ID,Orderitem.Amount,OrderItem.OrderStateKey,OrderItem.LastStateChanged,Category.CategoryName,Category.VAT,Category.CategoryType,OrderState.OrderStateInformation FROM OrderItem INNER JOIN[Order] ON[OrderItem].OrderID =[Order].OrderID INNER JOIN MenuItem ON OrderItem.MenuItemID = MenuItem.MenuItemID  INNER JOIN OrderState ON OrderState.OrderStateKey = OrderItem.OrderStateKey INNER JOIN Category ON Category.CategoryID = MenuItem.CategoryID WHERE[Order].TableNumber = @Id AND[Order].isFinished = 0; ";
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
                    OrderItemID = (int)dr["ID"],
                    MenuItem = menuItem,
                    Amount = (int)dr["Amount"],
                    DateTimeAdded = (DateTime)dr["LastStateChanged"],
                    orderState = (OrderState)Enum.Parse(typeof(OrderState), dr["OrderStateInformation"].ToString()),
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        private OrderItem ReadOrderItem(SqlDataReader dr)
        {
                MenuItem menuItem = new MenuItem()
                {
                    Name = dr["ItemName"].ToString(),
                    Price = float.Parse(dr["Price"].ToString()),
                    Stock = (int)dr["Stock"],
                    Description = dr["Description"].ToString(),
                };
                OrderItem orderItem = new OrderItem()
                {
                    OrderItemID = (int)dr["ID"],
                    MenuItem = menuItem,
                    Amount = (int)dr["Amount"],
                    DateTimeAdded = (DateTime)dr["LastStateChanged"],
                    orderState = (OrderState)Enum.Parse(typeof(OrderState), dr["OrderStateInformation"].ToString()),
                };                        
            return orderItem;
        }

        //Get all food for kitchen view
        public List<OrderItem> GetAllRunningFood()
        {
            OpenConnection();
            string query = "Select M.*,O.*,OrderStateInformation From[OrderItem] as O Inner join MenuItem as M On M.MenuItemID = O.MenuItemID Inner join Category as C On M.CategoryID = C.CategoryID inner join OrderState on O.OrderStateKey=OrderState.OrderStateKey Where C.CategoryType != 'Drinks' And O.OrderStateKey ='PR' Order by M.ItemName";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadAlltype(ExecuteSelectQuery(query, sqlParameters));

        }
        //Reading all food for kitchen view
        //loop over orderitem and menuitem to get Iteminfo
        private List<OrderItem> ReadAlltype(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    ID = (int)dr["ID"],
                    Name = dr["ItemName"].ToString(),
                    Price = float.Parse(dr["Price"].ToString()),
                    Stock = (int)dr["Stock"],
                    Description = dr["Description"].ToString(),
                    Category = dr["CategoryID"].ToString(),
                };
                OrderItem orderItem = new OrderItem()
                {   
                    OrderItemID=(int)dr["ID"],
                    OrderID =(int)dr["OrderID"],
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
        public List<OrderItem> GetAllRunningDrinks()
        {
            OpenConnection();
            string query = "Select M.*,O.*,OrderStateInformation From[OrderItem] as O Inner join MenuItem as M On M.MenuItemID = O.MenuItemID Inner join Category as C On M.CategoryID = C.CategoryID inner join OrderState on O.OrderStateKey=OrderState.OrderStateKey Where C.CategoryType = 'Drinks' And O.OrderStateKey ='PR' Order by M.ItemName";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadAlltype(ExecuteSelectQuery(query, sqlParameters));
        }
        //Get the table number for per OrderID
        public int GetOrderTable(int OrderID)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT TableNumber From [Order] where OrderID =@OrderID" , conn);
            cmd.Parameters.AddWithValue("@OrderId", OrderID);
            SqlDataReader reader = cmd.ExecuteReader();
            int table=0;
            if (reader.Read())
            {
                table = ReadTableNumber(reader);
            }

            reader.Close();
            conn.Close();
            return table;
        }
        public void SetOrderItemAsServed(OrderItem Item)
        {
            string query = "Update OrderItem SET OrderStateKey='OS' WHERE ID=@Id;";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@Id", Item.OrderItemID),
            };
            ExecuteEditQuery(query, parameters);
        }
        public int ReadTableNumber(SqlDataReader reader)
        {     
            return (int)reader["TableNumber"];
        }
       
        //This function will make Ready to serve Orderitem 
        public void UpdateReadyItem(OrderItem item)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update OrderItem Set OrderStateKey = 'RD' Where ID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", item.OrderItemID);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }
        public void UpdatePreparingItem(OrderItem item)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update OrderItem Set OrderStateKey = 'PR' Where ID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", item.OrderItemID);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }

    }
}