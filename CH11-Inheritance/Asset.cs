namespace CH11_Inheritance
{
    public abstract class Asset
    {
        public string Name { get; set; }
        protected int AssetId = 12355; // Note protected this is bad
        public virtual decimal Liability { get; } = 0; // Virtual
        public abstract decimal NetValue { get; }	// Note empty implementation
    }

    public class House : Asset
    {
        public decimal Mortgage;
        public decimal EstimatedHomeValue = 0;
        public override decimal Liability => Mortgage; // Overridden
        public override decimal NetValue => EstimatedHomeValue - Liability;
    }

    public class Stock : Asset
    {
        public long SharesOwned;

        // We won't override Liability here, because the default implementation will do.

        public decimal CurrentPrice;

        // Override like a virtual method.
        public override decimal NetValue => CurrentPrice * SharesOwned;

    }
}