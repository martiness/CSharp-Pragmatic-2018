using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork06
{
    //1. Generic Methods
    //a.Декларирайте generic метод Concatenate, който приема 2 аргумента left и right от тип T и връща string
    //b.Имплементирайте метода като връщате string, който конкатенира (съединява) съдържанието на двата аргумента 
    //  left и right със шпация между тях
    //c.В Main метода използвайте горния метод за да представите на екрана резултата
    //i.Concatenate<int>(7, 4)
    //ii.Concatenate<bool>(true, false)
    //iii.Concatenate<string>(“so much”, “fun”)

    public class Program
    {
        public static string Concatenate<T>(T Left, T Right)
        {
            return Left + " " + Right;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"Generic Example #1 INPUT <int>(7,4), OUTPUT: {Concatenate<int>(7, 4)}");
            Console.WriteLine($"Generic Example #2 INPUT <bool>(true, false), OUTPUT: {Concatenate<bool>(true, false)}");
            Console.WriteLine($"Generic Example #3 INPUT <string>('so much fun', 'fun'), OUTPUT: {Concatenate<string>("so much", "fun")}");

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
