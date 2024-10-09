using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Windows.Forms;

namespace midterm_Q2
{
    internal class Database
    {
        private string connectionString;


        public Database()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MobileMarketplaceDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Connection string 'MobileMarketplaceDB' not found in configuration file.");
            }
        }
        public string GetConnectionString()
        {
            return connectionString;
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
                            Console.WriteLine("SQL Error during ExecuteQuery: " + ex.Message);
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
                    try
                    {
                        return command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("SQL Error during ExecuteNonQuery: " + ex.Message);
                        return 0;
                    }
                }
            }
        }

        public int AddDevice(int userId, string deviceBrand, string deviceModel, string deviceOs, string deviceOsVersion, string deviceCondition, decimal price, string description, List<string> imagePaths)
        {
            int deviceId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert into Devices table
                        string deviceQuery = @"
                    INSERT INTO Devices 
                    (userId, deviceBrand, deviceModel, deviceOs, deviceOsVersion, deviceCondition, price, deviceDescription, createdAt, updatedAt) 
                    VALUES 
                    (@userId, @deviceBrand, @deviceModel, @deviceOs, @deviceOsVersion, @deviceCondition, @price, @deviceDescription, GETDATE(), GETDATE());
                    SELECT CAST(SCOPE_IDENTITY() as int);";

                        SqlParameter[] deviceParameters = new SqlParameter[]
                        {
                    new SqlParameter("@userId", userId),
                    new SqlParameter("@deviceBrand", deviceBrand),
                    new SqlParameter("@deviceModel", deviceModel),
                    new SqlParameter("@deviceOs", deviceOs),
                    new SqlParameter("@deviceOsVersion", deviceOsVersion),
                    new SqlParameter("@deviceCondition", deviceCondition),
                    new SqlParameter("@price", price),
                    new SqlParameter("@deviceDescription", description)
                        };

                        // Insert device and get generated deviceId
                        using (SqlCommand command = new SqlCommand(deviceQuery, connection, transaction))
                        {
                            command.Parameters.AddRange(deviceParameters);
                            object result = command.ExecuteScalar();
                            deviceId = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                            if (deviceId == 0)
                            {
                                throw new Exception("Failed to insert device.");
                            }
                        }

                        // Insert images for the new device
                        foreach (string imagePath in imagePaths)
                        {
                            string imageQuery = "INSERT INTO Photos (deviceId, filePath, uploadedAt) VALUES (@deviceId, @filePath, GETDATE())";
                            SqlParameter[] imageParameters = {
                        new SqlParameter("@deviceId", deviceId),
                        new SqlParameter("@filePath", imagePath)
                    };

                            using (SqlCommand imageCommand = new SqlCommand(imageQuery, connection, transaction))
                            {
                                imageCommand.Parameters.AddRange(imageParameters);
                                imageCommand.ExecuteNonQuery();
                            }
                        }

                        // Commit the transaction if all commands succeed
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"SQL Error during AddDevice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();  // Rollback if any failure
                        return 0;
                    }
                }
            }

            return deviceId;  // Return the generated deviceId
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
                    try
                    {
                        return command.ExecuteScalar();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("SQL Error during ExecuteScalar: " + ex.Message);
                        return null;
                    }
                }
            }
        }
    }
}
