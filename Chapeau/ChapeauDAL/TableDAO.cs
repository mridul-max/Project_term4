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
        //Changes the occupancy (for adding order and table display)
        public void SetOccupied(Table table)
        {
            string query = "UPDATE [Table] set IsOccupied = 1 WHERE TableNumber= @Id;";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@Id", table.TableNumber),
            };
            ExecuteEditQuery(query,parameters);
        }
        //Changes the occupancy (For after checking out)
        public void SetNoOccupied(Table table)
        {
            string query = "UPDATE [Table] set IsOccupied = 0 WHERE TableNumber= @Id;";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@Id", table.TableNumber),
            };
            ExecuteEditQuery(query,parameters);           
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
        // This methods are temporarily here they will be moved to orderDAO when it's created.
      
    }
}





