using System;


//2. Delegates and Lambda Expressions

//a.Декларирайте глобално в Program.cs делегат BooleanCondition, който връща bool и приема два аргумента a и b от тип int

//b. В Main метода декларирайте 3 променливи от тип BooleanCondition (изберете подходящи имена спрямо (c))

//c.Инициализирайте горните променливи с lambda expression-и, които:
//i.Ако a > b връща true, иначе false
//ii.Ако a<b връща true, иначе false
//iii. Ако a = b връща true, иначе false

//d. В Main метода използвайте горните 3 променливи (като методи!) за да изведете резултати на екрана при:
//i.a = 7 и b = 77
//ii.a = 1 и b = 1
//iii.a = 100 и b = 49

//e. (*) Направете BooleanCondition generic, т.е.да приема аргументи от произволен тип но винаги да връща bool. 
//Ипозлвайте по аналогичен начин като в(c) и(d). Използвайте отделен проект.


//a.Декларирайте глобално в Program.cs делегат BooleanCondition, който връща bool и приема два аргумента a и b от тип int

namespace HomeWork06_Delegates
{
    
    public delegate bool BooleanCondition(int a, int b);
    public class Program
    {
        public static void Main(string[] args)
        {
            //b. В Main метода декларирайте 3 променливи от тип BooleanCondition (изберете подходящи имена спрямо (c))
            BooleanCondition AGreaterThanB;
            BooleanCondition ALessThanB;
            BooleanCondition AEqualsToB;

            Console.WriteLine("Lambda Examples - Home work 06");
            //Console.Write("Enter value for A (0-1000): ");
            //int.TryParse(Console.ReadLine(), out int firstValue);

            //Console.Write("Enter value for B (0-1000): ");
            //int.TryParse(Console.ReadLine(), out int secondValue);


            //c.Инициализирайте горните променливи с lambda expression-и, които:
            //i.Ако a > b връща true, иначе false
            AGreaterThanB = (A, B) =>
            { 
                if(A > B)
                    return PrintGreater(A, B);
                else
                    return PrintNotGreater(A, B);
            };


            //Console.Write("Lambda Example #1 (Check A > B ? True : False) => ");
            //AGreaterThanB(firstValue, secondValue);

            //d. В Main метода използвайте горните 3 променливи (като методи!) за да изведете резултати на екрана при:
            //i.a = 7 и b = 77
            Console.Write("Lambda Example #1 (Check 7 > 77 ? True : False) => ");
            AGreaterThanB(7, 77);

            //cTrue = (a > b)
            //    ? PrintTrue
            //    : PrintFalse;

            //c.Инициализирайте горните променливи с lambda expression-и, които:
            //ii.Ако a<b връща true, иначе false
            ALessThanB = (A, B) =>
            {
                if (A < B)
                    return PrintNotLess(A, B);
                else
                    return PrintLess(A, B);
            };

            //Console.Write("Lambda Example #2 (Check A < B ? False : True) => ");
            //ALessThanB(firstValue, secondValue);

            //d. В Main метода използвайте горните 3 променливи (като методи!) за да изведете резултати на екрана при:
            //ii.a = 1 и b = 1
            Console.Write("Lambda Example #2 (Check 1 < 1 ? False : True) => ");
            ALessThanB(1, 1);

            //c.Инициализирайте горните променливи с lambda expression-и, които:
            //iii. Ако a = b връща true, иначе false
            AEqualsToB = (A, B) =>
            {
                if (A == B)
                    return PrintEquals(A, B);
                else
                    return PrintNotEquals(A, B);
            };


            //Console.Write("Lambda Example #3 (Check A == B ? True : False) => ");
            //AEqualsToB(firstValue, secondValue);

            //d. В Main метода използвайте горните 3 променливи (като методи!) за да изведете резултати на екрана при:
            //iii.a = 100 и b = 49
            Console.Write("Lambda Example #3 (Check 100 == 49 ? True : False) => ");
            AEqualsToB(100, 49);

            Console.WriteLine("Press any key to quit ...");
            Console.ReadKey();

        }

        static bool PrintGreater(int a, int b)
        {
            Console.WriteLine("True");
            return a > b;
        }

        static bool PrintNotGreater(int a, int b)
        {
            Console.WriteLine("False");
            return a < b;
        }

        static bool PrintLess(int a, int b)
        {
            Console.WriteLine("True");
            return a < b;
        }

        static bool PrintNotLess(int a, int b)
        {
            Console.WriteLine("True");
            return a < b;
        }

        static bool PrintEquals(int a, int b)
        {
            Console.WriteLine("True");
            return a == b;
        }

        static bool PrintNotEquals(int a, int b)
        {
            Console.WriteLine("False");
            return a != b;
        }


    }
}
