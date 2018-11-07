using System;

namespace Task1
{
    /// <summary>
    /// Class that describes Car 
    /// with Brand, Model, VIN, Mileage, Price
    /// </summary>
    public class Car
    {
        private readonly string _vin;

        public string Brand { get; set; }

        public string Model { get; set; }

        public string VIN { get { return _vin; } }

        public uint Mileage { get; set; }
        
        public decimal Price { get; set; }

        public string Message
        {
            get
            {
                return $"{Brand} ({Model}) - {Mileage} ({Price})";
            }

        }

        public Car(string brand, string model, string vin, uint mileage, decimal price)
        {
            Brand = brand;
            Model = model;
            // we want to set the ONLY once in the constructor 
            // and nowhere else;
            _vin = vin;
            Mileage = mileage;
            Price = price;
        }
    }
}
