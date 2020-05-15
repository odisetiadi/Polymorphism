using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 10*11");
        }



    }
}
