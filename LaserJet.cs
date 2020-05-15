using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 12*12");
        }
    }
}