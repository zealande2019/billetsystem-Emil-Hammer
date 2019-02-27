using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace UnitTestBilletSystem
{
    [TestClass]
    public class UnitTestMC
    {
        MC mc = new MC();

        // Testing that the value of a motorcycles vehicle status returns "MC".
        [TestMethod]
        public void TestMCKøretøj()
        {
            Assert.AreEqual(mc.VehicleStatus(), "MC");
        }
        
        // Testing that the price of a motorcycle returns 125.
        [TestMethod]
        public void TestMCPris()
        {
            Assert.AreEqual(mc.Price(), 125);
        }
    }
}