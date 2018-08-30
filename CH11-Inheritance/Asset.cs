namespace CH11_Inheritance
{
    public abstract partial class Asset : object //not needed, here for illustration 
    {
        private readonly int assetId;

        protected Asset(int assetId)
        {
            this.assetId = assetId; //use "this" because of shadowing
        }

        public string Name { get; set; }

        public virtual decimal Liability { get; } // Virtual and readonly

        public abstract decimal GetNetValue();

        public override string ToString()
        {
            return $"{Name} id: {assetId}";
        }
    }

    public class House : Asset
    {
        public House(int assetId) : base(assetId) //base(assetId) is used not this(assetId)
        {
            // this.assetId = 6;
        }

        public decimal Mortgage { get; set; } = 250000;
        public decimal EstimatedHomeValue { get; set; } = 0;

        public override decimal Liability
        {
            get { return Mortgage; }
        }

        public override decimal GetNetValue()
        {
            return EstimatedHomeValue - Liability;
        }

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
        public override decimal GetNetValue()
        {
            return CurrentPrice * SharesOwned;
        }

        public override string ToString() => $"{base.ToString()} is Stock Asset";
    }
}