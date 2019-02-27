using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace UnitTestBilletSystem
{
    [TestClass]
    public class UnitTestBil
    {
        Bil _bil = new Bil();

        [TestMethod]
        public void TestBilKøretøj()
        {
            Assert.AreEqual(_bil.Køretøj(), "Bil");
        }

        [TestMethod]
        public void TestBilPris()
        {
            Assert.AreEqual(_bil.Price(), 240);
        }
    }
}
