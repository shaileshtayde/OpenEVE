using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEVE.Data.Attributes
{
    public enum AttributeType : byte
    {
        None = 0,
        Fitting = 1,
        Shield = 2,
        Armor = 3,
        Structure = 4,
        Capacitor = 5,
        Targeting = 6,
        Miscellaneous = 7,
        RequiredSkills = 8,
        OtherCategory = 9,
        Drones = 10,
        //11 ?
        AI = 12,
    }
}
