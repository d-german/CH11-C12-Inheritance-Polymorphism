namespace Ch12Interface
{
    internal interface ISmartDevice //violates ISP
    {
        void Print();
        void Fax();
        void Scan();
    }
}