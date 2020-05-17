using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;
using SomerenDAL;
using System.Collections.Generic;

namespace ChapeauDAL
{
    public class TableDAO : Base
    {
        public TableDAO() : base() { }

        //class for communication with the database.
        // Returns all tables into a list from database.
        public List<Table> GetAllTables()
        {
            string query = "SELECT TableNumber,Capacity,IsOccupied FROM [Table];";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    TableNumber = (int)dr["TableNumber"],
                    Capacity = (int)dr["Capacity"],
                    IsOccupied = (bool)dr["IsOccupied"]

                };
                tables.Add(table);
            }
            return tables;
        }

        private Table ReadTable(SqlDataReader reader)
        {
            Table table = new Table()
            {
                TableNumber = (int)reader["TableNumber"],
                Capacity = (int)reader["Capacity"],
                IsOccupied = (bool)reader["IsOccupied"]
            };
            return table;
        }

        //Gets a table with a requested Id.
        public Table GetById(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT TableNumber,Capacity,IsOccupied FROM [Table] WHERE TableNumber=@Id;", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            Table table = null;

            if (reader.Read())
                table = ReadTable(reader);

            reader.Close();
            conn.Close();
            return table;
        }
        public List<OrderItem> GetOrderItemsofTable(int TableNr)
        {
            OpenConnection();
            string query = "SELECT MenuItem.*,Orderitem.Amount,OrderItem.OrderStateKey,OrderItem.OrderDateTime,Category.CategoryName,Category.VAT,Category.CategoryType,OrderState.OrderStateInformation FROM OrderItem INNER JOIN [Order] ON  [OrderItem].OrderID=[Order].OrderID INNER JOIN MenuItem ON OrderItem.MenuItemID = MenuItem.MenuItemID  INNER JOIN OrderState ON OrderState.OrderStateKey=OrderItem.OrderStateKey INNER JOIN Category ON Category.CategoryID = MenuItem.CategoryID WHERE [Order].TableNumber =@Id AND [Order].isFinished=0; ";
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
                    DateTimeAdded = (DateTime)dr["OrderDateTime"],
                    orderState = (OrderState)Enum.Parse(typeof(OrderState), dr["OrderStateInformation"].ToString()),
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
    }
}





