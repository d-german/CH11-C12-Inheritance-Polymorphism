using System.Collections.Generic;

namespace CH11_Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var assets = new List<Asset>
            {
                Asset.BuildAsset("House1", 20000)
            };
        }
    }
}