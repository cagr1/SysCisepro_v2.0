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

        public SalesData GetSalesDataRange(DateTime startDate, DateTime endDate)
        {
            var paramaters = new SqlParameter[]
            {
                new SqlParameter("@FECHA_INICIAL", startDate),
                new SqlParameter("@FECHA_FINAL", endDate)
            };

            DataTable resultTable = _databaseConnection.ExecuteStoredProcedure("sp_SalesDataByDateRange", paramaters);
            
            return new SalesData
            {
                TotalSales = resultTable.Rows.Count > 0 ? Convert.ToDecimal(resultTable.Rows[0]["TOTAL_VENTAS"]) : 0
            };



        }

        public SalesData GetAccumulatedSalesData(DateTime endDate)
        {
            var paramaters = new SqlParameter[]
            {
                
                new SqlParameter("@FECHA_FINAL", endDate)
            };

            DataTable resultTable = _databaseConnection.ExecuteStoredProcedure("sp_SalesAccumulatedByRange", paramaters);

            return new SalesData
            {
                TotalSales = resultTable.Rows.Count > 0 ? Convert.ToDecimal(resultTable.Rows[0]["TOTAL_VENTAS"]) : 0
            };

        }

        public List<AccumulatedProfitLossEarnings> GetAccumulatedProfitLossEarnings(int year)
        {
            var paramaters = new SqlParameter[]
            {
                new SqlParameter("@anio", year)
            };

            DataTable resultTable = _databaseConnection.ExecuteStoredProcedure("sp_ReportProfitLossEarnings", paramaters);

            return resultTable.AsEnumerable().Select(row => new AccumulatedProfitLossEarnings
            {
                NumberMonth = row.Field<int>("NumeroMes"),
                NameMonth = row.Field<string>("NombreMes"),
                TotalIncome = row.Field<decimal>("Ingresos"),
                TotalExpenses = row.Field<decimal>("Egresos"),
                TotalEarnings = row.Field<decimal>("Utilidad"),
            }).ToList();
            
        }

        public AnnualVariationRevenues GetAnnualVariationRevenues(DateTime startDate, DateTime endDate)
        {
            var paramaters = new SqlParameter[]
            {
                new SqlParameter("@FECHA_INICIAL", startDate ),
                new SqlParameter("@FECHA_FINAL", endDate )
            };

            DataTable resultTable = _databaseConnection.ExecuteStoredProcedure("sp_AnnualVariationRevenues", paramaters);

            return new AnnualVariationRevenues
            {
                VariationPercentage = resultTable.Rows.Count > 0 ? Convert.ToDecimal(resultTable.Rows[0]["VariacionPorcentual"]) : 0
            };
        }

        public AnnualRevenues GetAnnualRevenues(DateTime startDate, DateTime endDate)
        {
            var paramaters = new SqlParameter[]
            {
                new SqlParameter("@FECHA_INICIAL", startDate ),
                new SqlParameter("@FECHA_FINAL", endDate )
            };

            DataTable resultTable = _databaseConnection.ExecuteStoredProcedure("sp_AnnualRevenues", paramaters);

            return new AnnualRevenues
            {
                Assets = resultTable.Rows.Count > 0 ? Convert.ToDecimal(resultTable.Rows[0]["Activo"]) : 0,
                Liabiliteis = resultTable.Rows.Count > 0 ? Convert.ToDecimal(resultTable.Rows[0]["Pasivo"]) : 0,
                Equity = resultTable.Rows.Count > 0 ? Convert.ToDecimal(resultTable.Rows[0]["Patrimonio"]) : 0,
                Income = resultTable.Rows.Count > 0 ? Convert.ToDecimal(resultTable.Rows[0]["Utilidad"]) : 0
            };
        }


    }
}
