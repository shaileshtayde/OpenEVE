//OVER ENGINEERING

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OpenEVE.Data.FileSystem.Storage
//{
//    public class FolderStorage : BaseStorage
//    {
//        internal class FileResource : Resource
//        {
//            public FileResource(string location)
//                : base(location)
//            {

//            }

//            public override string Open()
//            {
//                if (string.IsNullOrEmpty(Location))
//                    throw new ArgumentNullException("Location");

//                if (!System.IO.File.Exists(Location))
//                    throw new FileNotFoundException(Location);

//                using (var fs = new FileStream(Location, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
//                using (var sr = new StreamReader(fs))
//                {
//                    return sr.ReadToEnd();
//                }
//            }
//        }

//        public string Folder { get; private set; }

//        public FolderStorage(string folder, string extension)
//        {
//            Folder = folder;
//            Extension = extension;

//            if (string.IsNullOrEmpty(Folder))
//                throw new ArgumentNullException("Folder");

//            if (!System.IO.Directory.Exists(Folder))
//                throw new DirectoryNotFoundException(Folder);
//        }

//        protected override Resource Get(string type)
//        {
//            if (string.IsNullOrEmpty(file))
//                throw new ArgumentNullException("file");

//            var path = System.IO.Path.Combine(Folder, file);
//            if (!System.IO.File.Exists(path))
//                throw new FileNotFoundException(path);

//            return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
//        }
//    }

//}
