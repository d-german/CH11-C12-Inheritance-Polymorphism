using System;

namespace Ch12Interface
{
    internal class EconomicPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine($"Printing from {GetType().Name}");
        }
    }
}