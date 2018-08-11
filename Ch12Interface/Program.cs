namespace Ch12Interface
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestIPrinter(new EconomicPrinter());
            TestIPrinter(new AllInOnePrinter());
        }

        private static void TestIPrinter(IPrinter printer)
        {
            printer.Print();
        }
    }
}