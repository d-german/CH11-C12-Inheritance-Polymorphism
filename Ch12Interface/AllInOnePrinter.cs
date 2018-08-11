using System;

namespace Ch12Interface
{
    internal class AllInOnePrinter : IPrinter, IFax, IScanner
    {
        public void Fax()
        {
            //Fax code
        }

        public void Print()
        {
            Console.WriteLine($"Printing from {GetType().Name}");
        }

        public void Scan()
        {
            //Scan code
        }
    }
}