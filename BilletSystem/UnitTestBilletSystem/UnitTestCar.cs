using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace UnitTestBilletSystem
{
    [TestClass]
    public class UnitTestCar
    {
        Car _car = new Car();

        // Testing that the value of a cars vehicle status returns "Bil".
        [TestMethod]
        public void TestVehicleStatus()
        {
            Assert.AreEqual(_car.VehicleStatus(), "Bil");
        }

        // Testing that the price of a car returns 240.
        [TestMethod]
        public void TestPrice()
        {
            Assert.AreEqual(_car.Price(), 240);
        }

        // Testing that an exception will be thrown when trying to input more than 7 characters in licenseplate
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLicenseplateOverLenghtException()
        {
            // Trying to set the license plate to 8 characters which is illegal.
            _car.Licenseplate = "12345678";

            //If the test continues it should fail.
            Assert.Fail();
        }

        // Testing that an exception will be thrown when trying to input more than 7 characters in licenseplate
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLicenseplateUnderLenghtException()
        {
            // Trying to set the license plate to 8 characters which is illegal.
            _car.Licenseplate = "";

            //If the test continues it should fail.
            Assert.Fail();
        }
    }
}
