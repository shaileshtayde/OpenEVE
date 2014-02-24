using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEVE.Data.EVEAI
{
    public class Repository : IRepository
    {
        private Stream currentStream;
        private StreamReader currentStreamReader;
        private string[] currentLine;
        private ZipFile zipFile;

        private MemoryTable<int, Icon> icons = new MemoryTable<int, Icon>();
        private MemoryTable<int, Race> races = new MemoryTable<int, Race>();

        public string File { get; private set; }

        public ITable<int, Icon> Icons { get { return icons; } }
        public ITable<int, Race> Races { get { return races; } }

        public Repository(string file)
        {
            File = file;
        }

        private void CleanUp()
        {
            if (currentStreamReader != null)
            {
                currentStreamReader.Close();
                currentStreamReader.Dispose();
                currentStreamReader = null;
            }

            if (currentStreamReader != null)
            {
                currentStreamReader.Close();
                currentStreamReader.Dispose();
                currentStreamReader = null;
            }

            currentLine = null;
        }

        private void LoadFile(string file)
        {
            CleanUp();

            var entry = zipFile.FindEntry(file, true);
            currentStream = zipFile.GetInputStream(entry);
            currentStreamReader = new StreamReader(currentStream);
        }

        private bool MoveNextRow()
        {
            var line = currentStreamReader.ReadLine();
            if (line == null)
            {
                CleanUp();
                return false;
            }

            currentLine = line.Split('$');
            return true;
        }

        public void Initialize()
        {
            if (string.IsNullOrEmpty(File))
                throw new ArgumentNullException("File");

            if (!System.IO.File.Exists(File))
                throw new FileNotFoundException(File);

            zipFile = new ZipFile(File);

            ReadIcons();
            ReadRaces();

            CleanUp();
        }

        #region Read Files
        private void ReadIcons()
        {
            const string FILE = "eveIcons.csv";
            const int ID = 0, ICONFILE = 1, DESC = 2;

            LoadFile(FILE);

            while (MoveNextRow())
            {
                var icon = new Icon()
                {
                    ID = ReadInt(ID),
                    File = ReadString(ICONFILE),
                    Description = ReadString(DESC)
                };

                icons.Add(icon.ID, icon);
            }
        }

        private void ReadRaces()
        {
            const string FILE = "chrRaces.csv";
            const int ID = 0, NAME = 1, DESC = 2, ICON = 3, SDESC = 4;
            
            LoadFile(FILE);

            while (MoveNextRow())
            {
                var race = new Race()
                {
                    ID = ReadInt(ID),
                    Name = ReadString(NAME),
                    Description = ReadString(DESC),
                    Icon = icons.GetByID(ReadInt(ICON)),
                    ShortDescription = ReadString(SDESC)
                };
                
                races.Add(race.ID, race);
            }
        }
        #endregion

        #region Read Types
        private void VerifyIndex(int index)
        {
            if (index < 0 || index >= currentLine.Length)
                throw new ArgumentOutOfRangeException("index");
        }

        private string ReadString(int index)
        {
            VerifyIndex(index);
            return currentLine[index];
        }

        private int ReadInt(int index)
        {
            VerifyIndex(index);
            if (currentLine[index] == string.Empty)
                return int.MinValue;

            return Convert.ToInt32(currentLine[index]);
        }

        private float ReadFloat(int index)
        {
            VerifyIndex(index);
            return Convert.ToSingle(currentLine[index]);
        }

        #endregion

    }
}
