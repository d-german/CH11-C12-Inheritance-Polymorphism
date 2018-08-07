using System;

namespace CH11_Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Asset a = new Stock(123);

            if (a is Stock)
            {
                Console.WriteLine(((Stock)a).SharesOwned);
            }
        }
    }
}