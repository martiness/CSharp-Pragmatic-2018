using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start Point
            // Change Background and Foreground Colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            // Print content on the screen
            Console.Write("NEW PROGRAM:   ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hello World");
            Console.WriteLine();

            Console.Write("What is your name? : ");
            string name = string.Empty;
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + name);

            float f = 0.1f; // 32 bit
            Console.WriteLine(f); // 0.1 (correct due to rounding)
            double d = 0.1f; // 64 bit
            Console.WriteLine(d); // 0.100000001490116 (incorrect)
            //decimal dec = 0.123;
            Console.WriteLine(@" test
            test new line");
            // Stop and wait for input

            float xx = 2 / 4;
            Console.WriteLine(xx);


            Console.ReadKey();

            //    enum cartype
            //    {
            //        Sedan,
            //        Wagoon,
            //        Coope, 
            //        Hedgeback
            //    }

            //int x;
            //cartype car;



            // Run program F5 or Ctrl + F5
        }
    }
}
