using System;
using System.Collections.Generic;

namespace DashboardAPI.Models
{
    public class SalesData
    {
        public int Year { get; set; }
        public decimal Sales { get; set; }
    }
    public class AccumulatedSalesData
    {
        public int Year { get; set; }
        public decimal AcumulatedSales { get; set; }
    }

    public class Variationdata
    {
        public int CurrentYear { get; set; }
        public int PreviousYear { get; set; }
        public decimal VariationPercentage { get; set; }
    }

    public class KpiData
    {
        public decimal TotalSalesCurrentYear { get; set; }
        public decimal TotalSalesPreviousYear { get; set; }
        public decimal SalesGrowthPercentage { get; set; }
        public decimal AverageMonthSales { get; set; }
    }

}
