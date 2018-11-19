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

namespace HomeWork06_Delegates_B
{
    //e. (*) Направете BooleanCondition generic, т.е.да приема аргументи от произволен тип но винаги да връща bool. 
    public delegate bool BooleanCondition<T>(T a, T b);

    public class Program
    {
        public static void Main(string[] args)
        {
            //b. В Main метода декларирайте 3 променливи от тип BooleanCondition (изберете подходящи имена спрямо (c))
            BooleanCondition<int> greaterThan;
            BooleanCondition<double> lessThan;
            BooleanCondition<string> equalsTo;

            //c.Инициализирайте горните променливи с lambda expression-и, които:
            Console.WriteLine("Lambda Examples - Home work 06 - B");
            //i.Ако a > b връща true, иначе false
            greaterThan = (A, B) => A.CompareTo(B) > 0;
            //ii.Ако a<b връща true, иначе false
            lessThan = (A, B) => A.CompareTo(B) < 0;
            //iii. Ако a = b връща true, иначе false
            equalsTo = (A, B) => A.CompareTo(B) == 0;

            //d. В Main метода използвайте горните 3 променливи (като методи!) за да изведете резултати на екрана при:
            //i.Ако a > b връща true, иначе false
            Console.Write("Lambda Example #1 (Check 7 > 77 ? True : False) => ");
            Console.WriteLine(greaterThan(7, 77));

            //ii.a = 1 и b = 1
            Console.Write("Lambda Example #2 (Check 1 < 1 ? False : True) => ");
            Console.WriteLine(lessThan(1.55, 2.33));

            //iii.a = 100 и b = 49
            Console.Write("Lambda Example #3 (Check 100 == 49 ? True : False) => ");
            Console.WriteLine(equalsTo("100", "49"));

            Console.WriteLine("Press any key to quit ...");
            Console.ReadKey();


        }
    }
}
