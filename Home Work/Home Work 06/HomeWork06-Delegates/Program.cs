using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork06_Delegates
{
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

    public delegate void BooleanCondition(int a, int b);
    public class Program
    {
        public static void Main(string[] args)
        {
            BooleanCondition cTrue;
            BooleanCondition cFalse;
            BooleanCondition cUnknown;
            int a = 5;
            int b = 4;

            //cTrue = (a > b)
            //    ? PrintTrue
            //    : PrintFalse;


        }

        static void PrintTrue()
        {
            Console.WriteLine("True");
        }

        static void PrintFalse()
        {
            Console.WriteLine("False");
        }
    }
}
