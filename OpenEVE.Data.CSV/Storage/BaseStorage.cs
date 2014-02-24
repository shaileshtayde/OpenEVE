//OVER ENGINEERING

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OpenEVE.Data.FileSystem.Storage
//{
//    public abstract class BaseStorage
//    {
//        public string Extension { get; protected set; }
//        public abstract string StorageType { get; }

//        protected abstract FileStream OpenFile(string file);

//        public Resource Get(string type)
//        {
//            return OpenFile(string.Format("{0}.{1}", type, Extension));
//        }
//    }

//}
