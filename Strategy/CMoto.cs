﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CMoto : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una moto, y me muevo con dos llantas");
        }
    }
}
