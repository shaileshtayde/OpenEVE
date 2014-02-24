using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEVE.Data
{
    public interface IRepository
    {
        ITable<int, Race> Races { get; }
        
        void Initialize();

    }
}
