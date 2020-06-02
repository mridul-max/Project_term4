using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;
using SomerenDAL;
using System.Collections.Generic;

namespace ChapeauDAL
{
    public class MenuItemDAO : Base
    {
        public List<MenuItem> GetCompleteMenu()
        {
            string query = "SELECT MenuItemID, ItemName, Price, Stock, [Description], CategoryType, CategoryName, VAT FROM MenuItem JOIN Category ON MenuItem.CategoryID = Category.CategoryID; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }
        public MenuItem GetById(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT MenuItemID, ItemName, Price, Stock, [Description], CategoryType, CategoryName, VAT FROM MenuItem JOIN Category ON MenuItem.CategoryID = Category.CategoryID WHERE MenuItemID = @Id; ", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            MenuItem item = null;

            if (reader.Read())
                item = ReadMenuItem(reader);

            reader.Close();
            conn.Close();
            return item;
        }

        public void UpdateStockOfItem(MenuItem item)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE MenuItem SET Stock =@Stock WHERE MenuItemID=@Id;", conn);
            cmd.Parameters.AddWithValue("@Stock", item.Stock);
            cmd.Parameters.AddWithValue("@Id",item.ID);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close(); 
        }
        public void CreateMenuItem(MenuItem item)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO MenuItem VALUES(@Category,@Name,@Price,@Stock,NULL);", conn);
            cmd.Parameters.AddWithValue("@Category", item.Category);
            cmd.Parameters.AddWithValue("@Name", item.Name);
            cmd.Parameters.AddWithValue("@Price", item.Price);
            cmd.Parameters.AddWithValue("@Stock", item.Stock);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }

        public void DeleteMenuItem(MenuItem item)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM MenuItem WHERE MenuItemID=@Id;", conn);
            cmd.Parameters.AddWithValue("@Id", item.ID);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }
        private List<MenuItem> ReadMenuItems(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem table = new MenuItem()
                {
                    ID = (int)dr["MenuItemID"],
                    Name = dr["ItemName"].ToString(),
                    Price = float.Parse(dr["Price"].ToString()),
                    Stock = (int)dr["Stock"],
                    Description = dr["Description"].ToString(),
                    CategoryType = (CategoryType)Enum.Parse(typeof(CategoryType), dr["CategoryType"].ToString()),
                    Category = dr["CategoryName"].ToString(),
                    VAT = ((int)dr["VAT"]) / 100f
                };
                menuItems.Add(table);
            }
            return menuItems;
        }
        private MenuItem ReadMenuItem(SqlDataReader dr)
        {                     
                MenuItem item = new MenuItem()
                {
                    ID = (int)dr["MenuItemID"],
                    Name = dr["ItemName"].ToString(),
                    Price = float.Parse(dr["Price"].ToString()),
                    Stock = (int)dr["Stock"],
                    Description = dr["Description"].ToString(),
                    CategoryType = (CategoryType)Enum.Parse(typeof(CategoryType), dr["CategoryType"].ToString()),
                    Category = dr["CategoryName"].ToString(),
                    VAT = ((int)dr["VAT"]) / 100f
                };                           
            return item;
        }
    }
}
