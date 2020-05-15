using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;
using ChapeauDAL;

namespace SomerenDAL
{
    public abstract class Base
    {
        protected SqlDataAdapter adapter;
        protected SqlConnection conn;
        public Base()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        protected SqlConnection OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                }
                return conn;
            }
            catch
            {             
                ErrorDAO error = new ErrorDAO("ChapeauApp Couldn't open the connection");
                return null;
            }
           
        }

        private void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("ChapeauApp couldn't close the connection");
            }
           
        }

        /* For Insert/Update/Delete Queries with transaction */
        protected void ExecuteEditTranQuery(String query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, conn, sqlTransaction);
            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch 
            {
                ErrorDAO error = new ErrorDAO("ChapeauApp couldn't execute the query");
            }
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(String query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch 
            {
                ErrorDAO error = new ErrorDAO("ChapeauApp couldn't execute the query");
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        /* For Insert/Update/Delete Queries with an auto_increment id value*/
        protected int ExecuteEditQueryAutoIncrement(String query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            int autoIncrementedId = -1;
            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;

                autoIncrementedId = int.Parse(command.ExecuteScalar().ToString());
            }
            catch 
            {
                ErrorDAO error = new ErrorDAO("ChapeauApp couldn't execute the query");
                throw;
            }
            finally
            {
                CloseConnection();
            }

            return autoIncrementedId;
        }

        /* For Select Queries */
        protected  DataTable ExecuteSelectQuery(String query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();
            
            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch 
            {
                ErrorDAO error = new ErrorDAO("ChapeauApp couldn't execute the query");
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }
       



    }
}
