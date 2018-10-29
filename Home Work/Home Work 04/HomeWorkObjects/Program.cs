using System;

namespace HomeWorkObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Console.Write("Enter Cars Number: ");
            input = Console.ReadLine();

            int newCarsNumber = 0;
            Int32.TryParse(input, out newCarsNumber);

            Car[] cars = new Car[newCarsNumber];

            Console.Clear();

            Console.WriteLine(" --- Car #{i} Description --- ");
            Console.Write("Enter Car #{i} Brand: ");
            input = Console.ReadLine();
            //cars[0].CarBrand = input;
            //cars[0].CarBrand = Car[0](input);

            Console.Write("Enter Car #{i} Model: ");
            cars[0].CarModel = Console.ReadLine();

            bool IsCarMileageValid = false;
            double carMilage = 0;
            do
            {
                Console.Write("Enter Car #{i} Mileage: ");
                input = Console.ReadLine();
                IsCarMileageValid = double.TryParse(input, out carMilage);
            }
            while (IsCarMileageValid == false);

            bool IsCarPriceValid = false;
            double carPrice = 0;
            do
            {
                Console.Write("Enter Car #{i} Price: ");
                input = Console.ReadLine();
                IsCarPriceValid = double.TryParse(input, out carPrice);
            }
            while (IsCarPriceValid == false);

        }
    }
}
