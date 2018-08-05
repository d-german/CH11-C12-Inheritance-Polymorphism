using System;
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
            var mansion = new House { Name = "McMansion", Mortgage = 250000 };
            Assert.AreEqual(250000, mansion.Liability);
        }
    }
}
