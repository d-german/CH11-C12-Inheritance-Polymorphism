namespace Ch12Interface
{
    internal interface ISmartDevice //violates ISP, SRP
    {
        void Print();
        void Fax();
        void Scan();
    }

    /*    
    ISP: The Interface Segregation Principle states that clients should not be forced to implement interfaces they don't use.
    Instead of one fat interface many small interfaces are preferred. 
    https://dzone.com/articles/solid-principles-by-example-interface-segregation
    https://www.oodesign.com/interface-segregation-principle.html
    */
}