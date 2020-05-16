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
        //public List<Order> GetAllPayments()
        //{
        //    string query = "SELECT [OrderID],TableNumber,EmployeeID,TotalPriceNoVAT,TotalPriceVAT,PaymentMethod,PaymentDateTime FROM [Order]; ";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        //}
        //private List<Order> ReadTables(DataTable dataTable)
        //{
        //    List<Order> payments = new List<Order>();

        //    foreach (DataRow dr in dataTable.Rows)
        //    {
        //        Order payment = new Order()
        //        {
        //            PaymentID = (int)dr["OrderID"],
        //            TableNumber = (int)dr["TableNumber"],
        //            EmployeeID = (int)dr["EmployeeID"],
        //            TotalPriceNoVAT = (float)dr["TotalPriceNoVAT"],
        //            TotalPriceVAT = (float)dr["TotalPriceVAT"],
        //            PaymentMethod = (int)dr["PaymentMethod"],
        //            PaymentDate = (DateTime)dr["PaymentDateTime"],
        //        };
        //        payments.Add(payment);
        //    }
        //    return payments;
        //}
        //public Order GetOrderById(int id)
        //{
        //    OpenConnection();
        //    SqlCommand cmd = new SqlCommand("SELECT [OrderID],TableNumber,EmployeeID,TotalPriceNoVAT,TotalPriceVAT,PaymentMethod,PaymentDateTimeFROM [Order] WHERE OrderID = @Id;", conn);
        //    cmd.Parameters.AddWithValue("@Id", id);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    Order payment = null;

        //    if (reader.Read())
        //        payment = ReadPayment(reader);

        //    reader.Close();
        //    conn.Close();
        //    return payment;
        //}
        //public void CompletePayment(Order payment)
        //{
                                 
        //    OpenConnection();
        //    SqlCommand cmd = new SqlCommand("INSERT INTO [Order] VALUES(@OrderID,@TableNumber,@EmployeeID,@TotalPriceNoVAT,@TotalPriceVAT,@PaymentMethod,@PaymentDateTime);", conn);
        //    cmd.Parameters.AddWithValue("@OrderID", payment.PaymentID);
        //    cmd.Parameters.AddWithValue("@TableNumber", payment.TableNumber);
        //    cmd.Parameters.AddWithValue("@EmployeeID", payment.EmployeeID);
        //    cmd.Parameters.AddWithValue("@TotalPriceNoVAT", payment.TotalPriceNoVAT);
        //    cmd.Parameters.AddWithValue("@TotalPriceVAT", payment.TotalPriceVAT);
        //    cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
        //    cmd.Parameters.AddWithValue("@PaymentDateTime", payment.PaymentDate);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    reader.Close();
        //    conn.Close();
        //}
        public void CreatePayment(int tableNumber,int employeeID)
        {

            OpenConnection();
            SqlCommand cmd = new SqlCommand("insert into [order] VALUES(@TableNumber,@EmployeeID,NULL,NULL,NULL,NULL);", conn);
            cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);           
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }

        //private Order ReadPayment(SqlDataReader reader)
        //{
        //    Order payment = new Order()
        //    {
        //        PaymentID = (int)reader["OrderID"],
        //        TableNumber = (int)reader["TableNumber"],
        //        EmployeeID = (int)reader["EmployeeID"],
        //        TotalPriceNoVAT = (float)reader["TotalPriceNoVAT"],
        //        TotalPriceVAT = (float)reader["TotalPriceVAT"],
        //        PaymentMethod = (int)reader["PaymentMethod"],
        //        PaymentDate = (DateTime)reader["PaymentDateTime"],
        //    };
        //    return payment;
        //}


    }
}
