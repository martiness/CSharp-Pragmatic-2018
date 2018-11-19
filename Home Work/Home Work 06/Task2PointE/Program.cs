using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2PointE
{
    // 2.e.  (*) Направете BooleanCondition generic, т.е.да приема аргументи от произволен тип 
    // но винаги да връща bool. Ипозлвайте по аналогичен начин като в(c) и(d). Използвайте отделен проект.
    class Program
    {
        static void Main(string[] args)
        {
            // the difference is only in these 3 lines!!!
            // -----------------------------------------------------
            // the moral is that we do not need to declare delegates
            // by ourselves, but rather use Func<> or Action<>
            // ...
            // still we need to to understand how they work :) 
            Func<int, int, bool> greater = (a, b) => a > b;
            Func<int, int, bool> lessThan = (a, b) => a < b;
            Func<int, int, bool> equal = (a, b) => a == b;

            Console.WriteLine("Greater");
            Console.WriteLine(new string('-', 20)); // initialize string with 20 times '-'
            Console.WriteLine($"7 > 77 => { greater(7, 77) }");
            Console.WriteLine($"1 > 1 => { greater(1, 1) }");
            Console.WriteLine($"100 > 49 => { greater(100, 49) }\n");

            Console.WriteLine("Less Than");
            Console.WriteLine(new string('-', 20)); // initialize string with 20 times '-'
            Console.WriteLine($"7 < 77 => { lessThan(7, 77) }");
            Console.WriteLine($"1 < 1 => { lessThan(1, 1) }");
            Console.WriteLine($"100 < 49 => { lessThan(100, 49) }\n");

            Console.WriteLine("Equal");
            Console.WriteLine(new string('-', 20)); // initialize string with 20 times '-'
            Console.WriteLine($"7 == 77 => { equal(7, 77) }");
            Console.WriteLine($"1 == 1 => { equal(1, 1) }");
            Console.WriteLine($"100 == 49 => { equal(100, 49) }\n");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
