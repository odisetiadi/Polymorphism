using System;

namespace polymorphism
 {
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer = new PrinterWindows();
            printer.Epson = "10*11";
            printer.Canon = "9.5*12";
            printer.LaserJet = "12*12";


            Console.WriteLine("Pilih Printer :");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Nomor Printer[1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            IPrinterWindows convert;

            if (nomorPrinter == 1)
                convert = new Epson();

            else if (nomorPrinter == 2)
                convert = new Canon();
            else
                convert = new LaserJet();

            convert.Convert(printer);
            Console.ReadKey();
        }
    }
}
