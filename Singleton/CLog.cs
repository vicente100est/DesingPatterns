using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class CLog
    {
        private static CLog _instance = new CLog();

        private string _path = "log.txt";

        public static CLog Instance
        {
            get
            {
                return _instance;
            }
        }
        private CLog()
        {
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
