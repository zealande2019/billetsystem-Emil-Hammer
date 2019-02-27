using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace UnitTestBilletSystem
{
    [TestClass]
    public class UnitTestMC
    {
        MC _mc = new MC();

        // Testing that the value of a motorcycles vehicle status returns "MC".
        [TestMethod]
        public void TestVehicleStatus()
        {
            Assert.AreEqual(_mc.VehicleStatus(), "MC");
        }
        
        // Testing that the price of a motorcycle returns 125.
        [TestMethod]
        public void TestPrice()
        {
            Assert.AreEqual(_mc.Price(), 125);
        }

        // Testing that an exception will be thrown when trying to input more than 7 characters in licenseplate
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLicenseplateOverLenghtException()
        {
            // Trying to set the license plate to 8 characters which is illegal.
            _mc.Licenseplate = "12345678";

            //If the test continues it should fail.
            Assert.Fail();
        }

        // Testing that an exception will be thrown when trying to input more than 7 characters in licenseplate
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLicenseplateUnderLenghtException()
        {
            // Trying to set the license plate to 8 characters which is illegal.
            _mc.Licenseplate = "";

            //If the test continues it should fail.
            Assert.Fail();
        }
    }
}