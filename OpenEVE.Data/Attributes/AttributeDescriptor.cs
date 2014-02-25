using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEVE.Data.Attributes
{
    public class AttributeDescriptor
    {
        public AttributeType Dategory;
        public double DefaultValue;
        public string Description;
        public string DisplayName;
        public Icon Icon;
        public bool IsHighGood;
        public bool IsStackable;
        public string Name;
        public bool Published;
        public Unit Unit;
    }
}
