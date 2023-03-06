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
        //private Car c1;

        //[TestInitialize] 
        //public void TestIn()
        //{ c1 = new Car("Honda", "501412", 5000); }

        //[TestMethod]
        //public void CarPriceTest()
        //{
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => c1.Price = 0);
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => c1.Price = 0);

        //    c1.Price = 10;

        //    Assert.AreEqual(10, c1.Price);
        //}

        [TestMethod]
        public void Model_SetWithValidValue_ShouldSetModel()
        {
            // Arrange
            var validModel = "ABCD";
            var sut = new Car(); // Assuming the code is within a class called MyClass

            // Act
            sut.Model = validModel;

            // Assert
            Assert.AreEqual(validModel, sut.Model);
        }

        [TestMethod]
        public void Model_SetWithNullValue_ShouldThrowArgumentException()
        {
            // Arrange
            string nullModel = null;
            var sut = new Car(); // Assuming the code is within a class called MyClass

            // Act & Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => sut.Model = nullModel);
            Assert.AreEqual("Model must be at least 4 characters.", ex.Message);
        }

        [TestMethod]
        public void Model_SetWithEmptyValue_ShouldThrowArgumentException()
        {
            // Arrange
            var emptyModel = string.Empty;
            var sut = new Car(); // Assuming the code is within a class called MyClass

            // Act & Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => sut.Model = emptyModel);
            Assert.AreEqual("Model must be at least 4 characters.", ex.Message);
        }

        [TestMethod]
        public void Model_SetWithShortValue_ShouldThrowArgumentException()
        {
            // Arrange
            var shortModel = "ABSD";
            var sut = new Car(); // Assuming the code is within a class called MyClass

            // Act & Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => sut.Model = shortModel);
            Assert.AreEqual("Model must be at least 4 characters.", ex.Message);
        }


    }
}