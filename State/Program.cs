using State.Class;
using System;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var curtomerContext = new CCustomerContext();
            Console.WriteLine(curtomerContext.GetState());

            curtomerContext.Request(100);
            Console.WriteLine(curtomerContext.GetState());

            curtomerContext.Request(50);
            Console.WriteLine(curtomerContext.GetState());

            curtomerContext.Request(100);
            Console.WriteLine(curtomerContext.GetState());

            curtomerContext.Request(50);
            Console.WriteLine(curtomerContext.GetState());

            curtomerContext.Request(50);
            Console.WriteLine(curtomerContext.GetState());
        }
    }
}
