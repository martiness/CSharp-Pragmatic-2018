using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //2. Delegates and Lambda Expressions
    //  a.Декларирайте глобално в Program.cs делегат BooleanCondition, който връща bool и приема два аргумента a и b от тип int
    //  b.	В Main метода декларирайте 3 променливи от тип BooleanCondition (изберете подходящи имена спрямо (c))
    //  c.Инициализирайте горните променливи с lambda expression-и, които:
    //      i.Ако a > b връща true, иначе false
    //      ii.Ако a < b връща true, иначе false
    //      iii.Ако a = b връща true, иначе false
    //  d.В Main метода използвайте горните 3 променливи (като методи!) за да изведете резултати на екрана при:
    //      i.a = 7 и b = 77
    //      ii.a = 1 и b = 1
    //      iii.a = 100 и b = 49

    delegate bool BooleanCondition(int a, int b);

    class Program
    {

        static void Main(string[] args)
        {
            BooleanCondition greater = (a, b) => a > b;
            BooleanCondition lessThan = (a, b) => a < b;
            BooleanCondition equal = (a, b) => a == b;

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
