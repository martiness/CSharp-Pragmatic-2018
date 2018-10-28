using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructSample
{
    public struct Point
    {
        public float X;
        public float Y;
    }

    public enum Country
    {
        Bulgaria = 0,
        Greece = 1,
        Macedonia = 2,
        Turkey = 3
    }

    public struct Address
    {
        public string AddressLine1;
        public string AddressLine2;
        public string City;
        public Country Country;
    }

    class StructSample
    {
        static void Main(string[] args)
        {
            Address customerBillingAddress = new Address()
            {
                AddressLine1 = "Mladost 2",
                AddressLine2 = "Drujba",
                City = "Sofia",
                Country = Country.Bulgaria
            };

            Console.WriteLine(customerBillingAddress);

            Console.ReadKey();
        }
    }
}
