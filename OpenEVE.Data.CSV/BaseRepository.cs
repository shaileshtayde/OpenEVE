//OVER ENGINEERING

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OpenEVE.Data.CSV
//{
//    public abstract class BaseRepository : IRepository
//    {
//        private Dictionary<int, Race> races = new Dictionary<int, Race>();       


//        public IEnumerable<Race> Races { get { return races.Values; } }

//        public void Initialize()
//        {
//            OnInitialize();
//        }

//        protected virtual void ReadRaces()
//        {
//            using (var fs = OpenStream("races"))
//            {

//            }
//        }

//        protected abstract void OnInitialize();
//        protected abstract FileStream OpenStream(string file);
//    }
//}
