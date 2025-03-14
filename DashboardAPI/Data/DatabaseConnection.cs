using System;
using System.Data;
using Microsoft.Data.SqlClient;

using Microsoft.Extensions.Configuration;


namespace DashboardAPI.Data
{
    public class DatabaseConnection
    {

        private readonly string _connectionString;

        public DatabaseConnection(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public DataTable ExecuteStoredProcedure(string spName, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the exception
                        Console.WriteLine($"Error executing stored procedure: {ex.Message}");
                        throw;
                    }
                }
            }

            return dataTable;
        }
    }
    
}
