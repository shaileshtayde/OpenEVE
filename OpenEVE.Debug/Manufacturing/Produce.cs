using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEVE.Debug.Manufacturing
{
    public class Produce : Item
    {
        public List<MaterialItem> Materials = new List<MaterialItem>();

        public double Sell = 0;
        public int UnitsPerRun = 1;
        public int TimePerRun = 4 * 60;

        public double RunsPerHour { get { return (60.0 * 60.0) / (double)TimePerRun; } }

        public double HourlyProfit { get { return UnitProfit * UnitsPerRun * RunsPerHour; } }

        public double UnitProfit { get { return Profit / UnitsPerRun; } }

        public double Profit
        {
            get
            {
                var cost = 0.0;
                foreach (var m in Materials)
                    cost += m.Item.Buy * m.Quantity;

                return ((UnitsPerRun * Sell) - cost);
            }
        }


        public void Add(Item item, int count)
        {
            Materials.Add(new MaterialItem() { Item = item, Quantity = count });
        }

        //public double Cost = 0;
        //public double InitialCost = 0;
        //public double CostPerUnit = 0;
        //public double SellPerUnit = 0;

        //public int UnitsPerRun = 1;

        //public bool CanBuild = true;

    }
}
