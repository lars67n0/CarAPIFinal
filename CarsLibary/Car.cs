using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibary
{
    public class Car
    {
        private int _id = 0;
        private string _model;
        private string _licensePlate;
        private int _price;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Car()
        { }

        public Car(string model, string licensePlate, int price) 
        {
            Id = 0;
            Model = model;
            LicensePlate = licensePlate;
            Price = price;

        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 4)
                {
                    throw new ArgumentException("Model must be at least 4 characters.");
                }
                _model = value;
            }
        }

        public string LicensePlate
            { get { return _licensePlate; }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 7)
                {
                    throw new ArgumentException("License plate must be between 2 and 7 characters.");
                }
                _licensePlate = value;
            }
        }

        public int Price
        {
            get { return _price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price must be above 0.");
            }
            _price = value;
        }
    }

    }
}
