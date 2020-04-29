﻿using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;

namespace SomerenDAL
{
    public abstract class Base
    {
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        public Base()
        {
            // DO NOT FORGET TO INSERT YOUR CONNECTION STRING NAMED 'SOMEREN DATABASE' IN YOUR APP.CONFIG!!
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        protected SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        private void CloseConnection()
        {
            conn.Close();
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
            catch (Exception e)
            {
                //Print.ErrorLog(e);
                throw e;
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
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw e;
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
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw e;
            }
            finally
            {
                CloseConnection();
            }

            return autoIncrementedId;
        }

        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(String query, params SqlParameter[] sqlParameters)
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
            catch (SqlException e)
            {
                //ErrorLog.Log(e.Message);
                return null;
                throw e;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }
    }
}
