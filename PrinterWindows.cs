using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    public class PrinterWindows
    {
        public string Namaprinter { get; set; }

        public virtual void Show()
        {
            Console.WriteLine();
        }
        public virtual void Print()
        {
            Console.WriteLine("Canon printer printing......");
        }
    }
}
