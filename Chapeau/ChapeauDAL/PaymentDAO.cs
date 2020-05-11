using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;
using SomerenDAL;
using System.Collections.Generic;

namespace ChapeauDAL
{
    public class PaymentDAO : Base
    {
        public PaymentDAO() : base() { }

        //class for communication with the database.
        // Returns all drinks into a list from database.
        public List<Payment> GetAllPayments()
        {
            string query = "SELECT [OrderID],TableNumber,EmployeeID,TotalPriceNoVAT,TotalPriceVAT,PaymentMethod,PaymentDateTime FROM [Order]; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Payment> ReadTables(DataTable dataTable)
        {
            List<Payment> payments = new List<Payment>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Payment payment = new Payment()
                {
                    PaymentID = (int)dr["OrderID"],
                    TableNumber = (int)dr["TableNumber"],
                    EmployeeID = (int)dr["EmployeeID"],
                    TotalPriceNoVAT = (float)dr["TotalPriceNoVAT"],
                    TotalPriceVAT = (float)dr["TotalPriceVAT"],
                    PaymentMethod = (int)dr["PaymentMethod"],
                    PaymentDate = (DateTime)dr["PaymentDateTime"],
                };
                payments.Add(payment);
            }
            return payments;
        }
        public Payment GetById(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT [OrderID],TableNumber,EmployeeID,TotalPriceNoVAT,TotalPriceVAT,PaymentMethod,PaymentDateTimeFROM [Order] WHERE OrderID = @Id;", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            Payment payment = null;

            if (reader.Read())
                payment = ReadPayment(reader);

            reader.Close();
            conn.Close();
            return payment;
        }
        public void CreatePayment(int OrderID,int tableNumber,int EmployeeID, float TotalPriceNoVAT,float TotalPriceVAT, int PaymentMethod,DateTime PaymentDate)
        {
                                 
            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Order]VALUES(@OrderID,@TableNumber,@EmployeeID,@TotalPriceNoVAT,@TotalPriceVAT,@PaymentMethod,@PaymentDateTime);", conn);
            cmd.Parameters.AddWithValue("@OrderID", OrderID);
            cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.Parameters.AddWithValue("@TotalPriceNoVAT", TotalPriceNoVAT);
            cmd.Parameters.AddWithValue("@TotalPriceVAT", TotalPriceVAT);
            cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            cmd.Parameters.AddWithValue("@PaymentDateTime", PaymentDate);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }


        private Payment ReadPayment(SqlDataReader reader)
        {
            Payment payment = new Payment()
            {
                PaymentID = (int)reader["OrderID"],
                TableNumber = (int)reader["TableNumber"],
                EmployeeID = (int)reader["EmployeeID"],
                TotalPriceNoVAT = (float)reader["TotalPriceNoVAT"],
                TotalPriceVAT = (float)reader["TotalPriceVAT"],
                PaymentMethod = (int)reader["PaymentMethod"],
                PaymentDate = (DateTime)reader["PaymentDateTime"],
            };
            return payment;
        }


    }
}
