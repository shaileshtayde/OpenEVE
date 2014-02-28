using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEVE.Debug.Manufacturing
{
    public class Job
    {
        public Produce Product;
        public int Runs = 1;

        public int TotalRunTime { get { return Product.TimePerRun * Runs; } }

        public double Profit(AssemblyLine line)
        {
            return Product.Profit * Runs - line.InstallCost; 
        }

        public double HourlyProfit(AssemblyLine line)
        {            
            var profit = Product.HourlyProfit - line.CostPerHour;
            return profit - (line.InstallCost / Math.Ceiling((double)TotalRunTime));
        }
    }
}
