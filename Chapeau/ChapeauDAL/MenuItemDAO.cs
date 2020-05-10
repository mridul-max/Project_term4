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
            string query = "SELECT ItemName, Price, Stock, [Description], CategoryType, CategoryName, VAT FROM MenuItem JOIN Category ON MenuItem.CategoryID = Category.CategoryID; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<MenuItem> ReadMenuItems(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem table = new MenuItem()
                {
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
    }
}
