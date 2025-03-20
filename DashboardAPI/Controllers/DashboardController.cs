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
        [HttpGet("sales/yearly")]
        public ActionResult <List<SalesData>> GetYearlySales([FromQuery] int startYear, [FromQuery] int endYear)
        {
         try
            {
                var salesData = _dashboardService.GetSalesData(startYear, endYear);
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
        public ActionResult<List<AccumulatedSalesData>> GetAccumulatedSales([FromQuery] int startYear, [FromQuery] int endYear)
        {
            try
            {
                var data = _dashboardService.GetAccumulatedSalesData(startYear,endYear);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }


    }
}
