﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace midterm_Q2
{
    internal class Database
    {
        private string query;
        private DataTable data;
        private string connectionString;

        public Database()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PhoneMarketplaceDB"].ConnectionString;

            query = "SELECT * FROM phones1";

            Console.WriteLine("Connection String: " + connectionString);
            Console.WriteLine("Query: " + query);

            data = ExecuteQuery(query);
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable result = new DataTable();
                        try
                        {
                            adapter.Fill(result);
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine("SQL Error: " + ex.Message); // Log the error
                        }
                        return result;
                    }
                }
            }
        }
        

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }


        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteScalar();
                }
            }
        }
    }
}
