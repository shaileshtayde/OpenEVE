using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEVE.Data
{
    public class Icon
    {
        public static readonly Icon Null = new Icon() { ID = -1, File = string.Empty, Description = string.Empty };

        public int ID;
        public string File;
        public string Description;
    }
}
