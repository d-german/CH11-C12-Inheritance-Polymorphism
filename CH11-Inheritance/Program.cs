using System;
using System.Collections.Generic;

namespace CH11_Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var assets = new List<Asset>
            {
                Asset.BuildAsset("House1", 19999),
                Asset.BuildAsset("House2", 20000),
                Asset.BuildAsset("Stock1", 30000),
                Asset.BuildAsset("Stock2", 30001)
            };

            foreach (var asset in assets)
            {
                Console.WriteLine(asset); //asset.ToString();
            }

            try
            {
                var houseAsset = Asset.BuildAsset("House3", 19999);
                var badStock = (Stock)houseAsset;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            Asset houseAssetAsset = Asset.BuildAsset("House4", 19999);
            Stock stock = houseAssetAsset as Stock;

            if (stock == null)
            {
                Console.WriteLine("????????????????????");
            }
            else
            {

                Console.WriteLine(stock);

            }


        }
    }
}