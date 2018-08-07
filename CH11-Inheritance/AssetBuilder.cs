namespace CH11_Inheritance
{
    public abstract partial class Asset
    {
        public static Asset BuildAsset(string name, int id = 0)
        {

            switch (id)
            {
                case int c when c <= 20000:
                    return new House(id) { Name = name };
                case int c when c <= 30000:
                    return new Stock(id) { Name = name };
                default:
                    return null;
            }



        }


    }
}