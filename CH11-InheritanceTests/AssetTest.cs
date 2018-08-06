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
            var mansion = new House(123) {Name = "McMansion", Mortgage = 250000};
            Assert.AreEqual(250000, mansion.Liability);
        }

        [TestMethod]
        public void ToStringTest()
        {
            var mansion = new House(555) {Name = "McMansion", Mortgage = 250000};
            const string expected = "McMansion id: 555 is House Asset";
            var actual = mansion.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}