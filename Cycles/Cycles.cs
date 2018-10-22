using System;

namespace Cycles
{
    class Cycles
    {
        static void Main(string[] args)
        {
            byte age = 0;

            bool validInput = false;

            do
            {
                Console.WriteLine("Age: ");
                if (byte.TryParse(Console.ReadLine(), out age))
                {
                    if (age > 12 && age < 120)
                    {
                        validInput = true;
                    }
                }

            } while (!validInput);


            while (!validInput)
            {
                Console.WriteLine("Age: ");
                if (byte.TryParse(Console.ReadLine(), out age))
                {
                    if (age > 12 && age < 120)
                    {
                        validInput = true;
                    }
                }
            };


            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }


        }

        public static int Factoriel(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return (n * Factoriel(n - 1));
        }
    }
}
