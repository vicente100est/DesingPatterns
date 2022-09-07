using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CSingleton singleton = CSingleton.Instance;

            CLog log = Singleton.CLog.Instance;

            log.Save("Vicente Estrada");
            log.Save("Maria Isabel Dominguez");
        }
    }
}
