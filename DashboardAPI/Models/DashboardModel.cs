using System;
using System.Collections.Generic;

namespace DashboardAPI.Models
{
    public class SalesData
    {
        
        public decimal TotalSales { get; set; }
    }
    public class AccumulatedProfitLossEarnings
    {
        public int NumberMonth { get; set; }
        public string NameMonth { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal TotalEarnings { get; set; }

    }

    public class AnnualVariationRevenues
    {
    
        public decimal VariationPercentage { get; set; }
    }

    public class AnnualRevenues
    {
        public decimal Assets  { get; set; }
        public decimal Liabiliteis { get; set; }

        public decimal Equity { get; set; }

        public decimal Income { get; set;}
    }






}
