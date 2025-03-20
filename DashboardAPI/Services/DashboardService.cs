using DashboardAPI.Data;
using DashboardAPI.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DashboardAPI.Services
{
    public class DashboardService
    {
        private readonly DatabaseConnection _databaseConnection;

        public DashboardService(IConfiguration configuration)
        {
            _databaseConnection = new DatabaseConnection(configuration);
        }

        public List<SalesData> GetSalesData(int startYear, int endYear)
        {
            //var paramaters = new SqlParameter[]
            //{
            //    new SqlParameter("@StartYear", startYear),
            //    new SqlParameter("@EndYear", endYear)
            //};

            //DataTable dataTable = _databaseConnection.ExecuteStoredProcedure("sp_GetSalesData", paramaters);

            //return dataTable.AsEnumerable().Select(row => new SalesData
            //{
            //    Year = row.Field<int>("Year"),
            //    Sales = row.Field<decimal>("Sales")
            //}).ToList();

            return new List<SalesData> {
        new SalesData { Year = 2023, Sales = 150000 },
        new SalesData { Year = 2024, Sales = 200000 }
    };


        }

        public List<AccumulatedSalesData> GetAccumulatedSalesData(int startYear, int endYear)
        {
            var paramaters = new SqlParameter[]
            {
                new SqlParameter("@StartYear", startYear),
                new SqlParameter("@EndYear", endYear)
            };

            DataTable dataTable = _databaseConnection.ExecuteStoredProcedure("sp_GetAcumulatedSalesData", paramaters);

            return dataTable.AsEnumerable().Select(row => new AccumulatedSalesData
            {
                Year = row.Field<int>("Year"),
                AcumulatedSales = row.Field<decimal>("AcumulatedSales")
            }).ToList();
        }

       

    }
}
