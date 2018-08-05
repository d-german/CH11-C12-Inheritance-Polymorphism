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
        public decimal Mortgage { get; set; }
        public decimal EstimatedHomeValue { get; set; } = 0;

        public override decimal Liability => Mortgage; // Overridden
        public override decimal NetValue => EstimatedHomeValue - Liability;
    }

    public class Stock : Asset
    {
        public long SharesOwned { get; set; }
        public decimal CurrentPrice { get; set; }

        // We won't override Liability here, because the default implementation will do.
        public override decimal NetValue => CurrentPrice * SharesOwned;

    }
}