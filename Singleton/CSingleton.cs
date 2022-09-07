using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class CSingleton
    {
        private readonly static CSingleton _instance = new CSingleton();

        public static CSingleton Instance
        {
            get { return _instance; }
        }
        private CSingleton() { }
    }
}
