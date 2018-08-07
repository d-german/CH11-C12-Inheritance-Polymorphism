namespace CH11_Inheritance
{
    public abstract class Asset : object
    {
        private int assetId = 12355;

        protected Asset(int assetId) => this.assetId = assetId;

        public string Name { get; set; }

        public virtual decimal Liability { get; } = 0; // Virtual
        public abstract decimal NetValue { get; } // Note empty implementation

        public override string ToString() => $"{Name} id: {assetId}";
    }

    public class House : Asset
    {
        public House(int assetId) : base(assetId)
        {
            // this.assetId = 6;
        }

        public decimal Mortgage { get; set; }
        public decimal EstimatedHomeValue { get; set; } = 0;

        public override decimal Liability => Mortgage; // Overridden
        public override decimal NetValue => EstimatedHomeValue - Liability;

        public override string ToString() => $"{base.ToString()} is House Asset";
    }

    public class Stock : Asset
    {
        public Stock(int assetId) : base(assetId)
        {
        }

        public long SharesOwned { get; set; }
        public decimal CurrentPrice { get; set; }

        // We won't override Liability here, because the default implementation will do.
        public override decimal NetValue => CurrentPrice * SharesOwned;

        public override string ToString() => $"{base.ToString()} is Stock Asset";
    }
}