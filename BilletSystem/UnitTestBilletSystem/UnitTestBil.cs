using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace UnitTestBilletSystem
{
    [TestClass]
    public class UnitTestBil
    {
        Bil _bil = new Bil();

        // Testing that the value of a cars vehicle status returns "Bil".
        [TestMethod]
        public void TestBilK�ret�j()
        {
            Assert.AreEqual(_bil.K�ret�j(), "Bil");
        }

        // Testing that the price of a car returns 240.
        [TestMethod]
        public void TestBilPris()
        {
            Assert.AreEqual(_bil.Price(), 240);
        }
    }
}
