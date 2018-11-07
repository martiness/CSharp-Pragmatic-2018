using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Създайте клас Car, който описва марка, модел, пробег и цена. В главния метод(e.g.Main):
            //    a.Декларирайте масив от коли
            //    b.Прочетете цяло число N от потребителя
            //    c.Добавете N на брой коли в масива
            //    d.Изчистете екрана и изведете данните за колите в следния формат: Марка(Модел) - пробег(цена)


            // a.
            Car[] myCars;

            // b.
            Console.Write("How many cars do you have: ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            // c. 
            Random rnd = new Random();
            myCars = new Car[n];
            for (int i = 0; i < myCars.Length; i++)
            {
                myCars[i] = new Car(
                        $"Brand Type {rnd.Next(1, 50)}",
                        $"Model Type {rnd.Next(25, 50)}",
                        $"VIN{rnd.Next(100000, 500000)}",
                        (uint)rnd.Next(150000, 500000),
                        Convert.ToDecimal(rnd.Next(10000, 150000))
                    );
            }

            // d.
            Console.Clear();

            for (int i = 0; i < myCars.Length; i++)
                Console.WriteLine(myCars[i].Message);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
