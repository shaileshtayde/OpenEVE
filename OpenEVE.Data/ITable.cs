using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEVE.Data
{
    public interface ITable<T, K> : IEnumerable<K>
    {
        K GetByID(T t);
    }
}
