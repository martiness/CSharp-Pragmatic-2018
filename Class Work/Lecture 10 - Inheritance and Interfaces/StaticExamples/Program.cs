using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            // call static method
            Console.WriteLine(Calculator.Add(2, 2));

            // call non-static (instance) method
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Substract(3, 3));

            // use static class
            Console.WriteLine(StaticCalculator.Add(2,2));
            Console.WriteLine(StaticCalculator.Substract(3, 3));

            // Static classes cannot be instantiated!!!
            // StaticCalculator c = new StaticCalculator();

            // use static property 
            Console.WriteLine(StaticCalculator.Version);
            Console.WriteLine(Calculator.Version);
            
            // It's not possible to access static member from the instance variable
            // Console.WriteLine(calc.Version);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
