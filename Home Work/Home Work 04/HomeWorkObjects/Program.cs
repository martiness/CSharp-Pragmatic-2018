using System;

namespace HomeWorkObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = string.Empty;
            Console.Write("Enter Cars Number: ");
            input = Console.ReadLine();

            int newCarsNumber = 0;
            Int32.TryParse(input, out newCarsNumber);
            Car[] cars = new Car[newCarsNumber];
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < newCarsNumber; i++)
            {
                cars[i] = new Car();
                Console.WriteLine($" --- Car #{i+1} Description --- ");
                Console.Write($"Enter Car #{i+1} Brand: ");
                input = Console.ReadLine();
                cars[i].CarBrand = input;

                Console.Write($"Enter Car #{i+1} Model: ");
                cars[i].CarModel = Console.ReadLine();

                bool IsCarMileageValid = false;
                double carMileage = 0;
                do
                {
                    Console.Write($"Enter Car #{i+1} Mileage: ");
                    input = Console.ReadLine();
                    IsCarMileageValid = double.TryParse(input, out carMileage);
                    if (!IsCarMileageValid)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entered Car Mileage is not valid! Try  again");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        cars[i].CarMileage = carMileage;
                    }
                }
                while (IsCarMileageValid == false);

                bool IsCarPriceValid = false;
                double carPrice = 0;
                do
                {
                    Console.Write($"Enter Car #{i+1} Price: ");
                    input = Console.ReadLine();
                    IsCarPriceValid = double.TryParse(input, out carPrice);
                    if (!IsCarPriceValid)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entered Car Price is not valid! Try  again");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        cars[i].CarPrice = carPrice;
                    }
                }
                while (IsCarPriceValid == false);

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cars Print List");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < newCarsNumber; i++)
            {
                
                Console.WriteLine($"Car #{i + 1}");
                Console.WriteLine($"Brand: {cars[i].CarBrand}");
                Console.WriteLine($"Model: {cars[i].CarModel}");
                Console.WriteLine($"Mileage: {cars[i].CarMileage}");
                Console.WriteLine($"Price: {cars[i].CarPrice}");
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
