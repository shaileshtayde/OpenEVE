using OpenEVE.Debug.Manufacturing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEVE.Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            //var r = new OpenEVE.Data.EVEAI.Repository(@"C:\Users\Xposure\Downloads\EveAI.Data.zip");
            //r.Initialize();

            var line = new AssemblyLine();

            var product = new List<Produce>();

            var nocxium = new Item() { Buy = 702.72 };
            var pyerite = new Item() { Buy = 12.47 };
            var tritanium = new Item() { Buy = 4.83 };

            var antimatters = new Produce() { UnitsPerRun = 100, Sell = 29.08 };
            antimatters.Add(nocxium, 1);
            antimatters.Add(pyerite, 17);
            antimatters.Add(tritanium, 202);

            product.Add(antimatters);

            foreach (var p in product)
                Console.WriteLine("ID: {0}, UnitProfit: {1}, HourlyProfit: {2}", p.ID, p.UnitProfit, p.HourlyProfit - line.CostPerHour);

            Console.Read();
        }
    }
}
