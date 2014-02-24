using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEVE.Data
{
    public class MemoryTable<T, K> : ITable<T, K>
    {
        private Dictionary<T, K> data = new Dictionary<T, K>();

        public K GetByID(T t)
        {
            return data.GetByKey(t);
        }

        public IEnumerator<K> GetEnumerator()
        {
            foreach (var k in data.Values)
                yield return k;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (var k in data.Values)
                yield return k;
        }

        public void Add(T t, K k)
        {
            data.Add(t, k);
        }
    }
}
