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
            var r = new OpenEVE.Data.EVEAI.Repository(@"C:\Users\Xposure\Downloads\EveAI.Data.zip");
            r.Initialize();
        }
    }
}
