using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using DashboardAPI.Data;
using DashboardAPI.Services;
using DashboardAPI.Models;

namespace DashboardAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly DashboardService _dashboardService;

        public DashboardController(DashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        //Endpoint to get sales per year
        [HttpGet("sales/by-date")]
        public ActionResult<SalesData> GetSalesData([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
         try
            {
                var salesData = _dashboardService.GetSalesDataRange(startDate, endDate);
                return Ok(salesData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, ex.Message);
            }
            
        }

        // Endpoint para ventas acumuladas
        [HttpGet("sales/accumulated")]
        public ActionResult<SalesData> GetAccumulatedSales( [FromQuery] DateTime endDate)
        {
            try
            {
                var data = _dashboardService.GetAccumulatedSalesData(endDate);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        //Endpoint para obtener reporte de Ingresos, Egresos y Utilidades
        [HttpGet("profit-loss-byMonth")]
        public ActionResult<List<AccumulatedProfitLossEarnings>> GetAccumulatedProfitLossEarnings([FromQuery] int year)
        {
            try
            {
                var data = _dashboardService.GetAccumulatedProfitLossEarnings(year);
                return Accepted(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        //Endpoint para obtener variación anual de ingresos
        [HttpGet("annual-variation-revenues")]
        public ActionResult<AnnualVariationRevenues> GetAnnualVariationRevenues([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            try
            {
                var data = _dashboardService.GetAnnualVariationRevenues(startDate,endDate);
                return Accepted(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        //Endpoint para obtener reporte de activos, pasivos, patrimonio e ingresos
        [HttpGet("annual-revenues")]
        public ActionResult<AnnualRevenues> GetAnnualRevenues([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            try
            {
                var data = _dashboardService.GetAnnualRevenues(startDate,endDate);
                return Accepted(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
    }
}
