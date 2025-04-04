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

        public async Task<DataTable> ExecuteStoredProcedure(string spName, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        await connection.OpenAsync();
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the exception
                        Console.WriteLine($"Error executing stored procedure: {ex.Message}");
                        throw;
                    }
                }
            return dataTable;
            }

            
        }
    }
    

