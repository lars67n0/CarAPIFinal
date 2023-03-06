using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using CarsLibary;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore;

namespace CarAPIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarRest : ControllerBase
    {
        private static int _nextId = 1;

        private static List<Car> GetCars()
        {
            Car c1 = new Car("BMWS", "121512", 1500); c1.Id = _nextId; _nextId++;
            Car c2 = new Car("Honda", "33312", 2200); c2.Id = _nextId; _nextId++;
            Car c3 = new Car("Peuget", "121541", 3300); c3.Id = _nextId; _nextId++;
            Car c4 = new Car("Audi", "129023", 4400); c4.Id = _nextId; _nextId++;

            List<Car> listToReturn = new List<Car>() { c1, c2, c3, c4 };

            return listToReturn;
        }

        private static List<Car> list = GetCars();

        public static void Clear()
        {
            list = new List<Car>();
            _nextId= 1;
        }

        [HttpGet]
        public List<Car> Get()
        {
            return list;
        }

        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return list.Find(c => c.Id == id);
        }


        [HttpPost]
        public Car Post([FromBody] Car value)
        {
            Car c = value;
            c.Id = _nextId;
            list.Add(value);
            _nextId++;
            return c;
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Car value)
        {
            Car c = Get(id);
            if (c != null)
            {
                c.Model = value.Model;
                c.LicensePlate = value.LicensePlate;
                c.Price = value.Price;
            }
            else
            {
                
            }
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            list.Remove(Get(id));
        }

    }
}
