using CH11_Inheritance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CH11_InheritanceTests
{
    [TestClass]
    public class AssetTest
    {
        [TestMethod]
        public void HouseLiabilityTest()
        {
            var mansion = new House(assetId:123) {Name = "McMansion", Mortgage = 250001};
            Assert.AreEqual(250001, mansion.Liability);
        }

        [TestMethod]
        public void ToStringTest()
        {
            var mansion = new House(555) {Name = "McMansion", Mortgage = 250000};
            const string expected = "McMansion id: 555 is House Asset";
            var actual = mansion.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AssetBuilderTest()
        {
            var asset = Asset.BuildAsset("My House", 20000);
            Assert.IsTrue(asset is House);

            var type = asset.GetType();
            Assert.IsTrue(type.FullName.Equals("CH11_Inheritance.House"));

            var house = asset as House;
            Assert.IsTrue(house.Mortgage.Equals(250000));
        }
    }
}