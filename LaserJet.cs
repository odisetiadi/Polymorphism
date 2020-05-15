﻿using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    public class LaserJet : IPrinterWindows
    {
        public void Convert(PrinterWindows printer)
        {
            Console.WriteLine("Canon display dimension : {0}", printer.LaserJet);
        }
    }
}