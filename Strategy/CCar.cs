using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CCar : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy un carro, yme muevo con 4 llantas");
        }
    }
}
