using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarsLibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibary.Tests
{
    [TestClass()]
    public class CarTests
    {
        // Model Length Val

        [TestMethod]
        public void Model_SetWithValidValue_ShouldSetModel()
        {
            // Arrange
            var validModel = "ABCD";
            var sut = new Car(); 

            // Act
            sut.Model = validModel;

            // Assert
            Assert.AreEqual(validModel, sut.Model);
        }

        

        

        [TestMethod]
        public void Model_SetWithShortValue_ShouldThrowArgumentException()
        {
            // Arrange
            var shortModel = "ABS";
            var sut = new Car(); 

            // Act & Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => sut.Model = shortModel);
            Assert.AreEqual("Model must be at least 4 characters.", ex.Message);
        }

        // Price
        [TestMethod]
        public void PriceProperty_SettingInvalidValue_ThrowsArgumentException()
        {
            // Arrange
            var product = new Car();
            int invalidPrice = 0;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => product.Price = invalidPrice);
        }


        //LicensePlate
        [TestMethod]
        public void LicensePlateProperty_SettingInvalidLength_ThrowsArgumentException()
        {
            // Arrange
            var car = new Car();
            string invalidLicensePlate = "";

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => car.LicensePlate = invalidLicensePlate);
        }

    }
}