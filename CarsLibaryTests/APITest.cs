using CarsLibary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAPIFinal;
using Microsoft.AspNetCore.Routing;
using CarAPIFinal.Controllers;
using Microsoft.AspNetCore.Mvc;





namespace CarsLibaryTests
{

    [TestClass()]
    public class APITest
    {

        private Car c1;
        private CarRest Controller;

        [TestInitialize]
        public void TestInit()
        {
            c1 = new Car("HOWDI", "141519", 2020);
            Controller = new CarRest ();
            CarRest.Clear();
        }


        [TestMethod]
        public void TestPost()
        {
            Controller.Post(c1);
            Controller.Post(c1);
            Car cc1 = Controller.Post(c1);

            Assert.AreEqual(3, cc1.Id);
        }


        [TestMethod]
        public void TestGetId()
        {
            Car car1 = new Car("Lækkert", "ÅH1092", 10000);
            Car car2 = new Car("Poli", "PO09123", 1);
            Car car3 = new Car("Lona", "AC25879", 5000);
            Car car4 = new Car("Honda", "LO10123", 9000);

            Car cc1 = Controller.Post(car1);
            Car cc2 = Controller.Post(car2);
            Car cc3 = Controller.Post(car3);
            Car cc4 = Controller.Post(car4);
            Assert.AreEqual(1, Controller.Get(1).Id);
        }
    }

    
}
