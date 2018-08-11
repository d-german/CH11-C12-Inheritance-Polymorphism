namespace Ch12Interface
{
    internal interface ISmartDevice //violates ISP, SRP
    {
        void Print();
        void Fax();
        void Scan();
    }
}