using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CBicycles : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Hola prro, soy una bicycle, y me muevo con dos llantas");
        }
    }
}
