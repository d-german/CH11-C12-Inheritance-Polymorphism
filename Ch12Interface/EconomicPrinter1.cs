using System;

namespace Ch12Interface
{
    public class EconomicPrinter1 : ISmartDevice
    {
        public void Print()
        {
            //Yes I can print.
        }

        public void Fax()
        {
            throw new NotSupportedException();
        }

        public void Scan()
        {
            throw new NotSupportedException();
        }
    }
}