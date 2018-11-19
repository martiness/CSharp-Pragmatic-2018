using System;

namespace Task1
{
    //1.Generic Methods
    //  a.Декларирайте generic метод Concatenate, който приема 2 аргумента left и right 
    //    от тип T и връща string
    //  b.Имплементирайте метода като връщате string, който конкатенира (съединява) 
    //    съдържанието на двата аргумента left и right със шпация между тях
    //  c.В Main метода използвайте горния метод за да представите на екрана резултата
    //      i.Concatenate<int>(7, 4)
    //      ii.Concatenate<bool>(true, false)
    //      iii.Concatenate<string>(“so much”, “fun”)
    class Program
    {
        // old school declaration
        //string Concatenate<T>(T left, T right)
        //{
        //    return $"{left} {right}";
        //}

        // you can use lambda expression as method bodies as well :) 
        static string Concatenate<T>(T left, T right) => $"{left} {right}";        

        static void Main(string[] args)
        {
            Console.WriteLine(Concatenate(7, 4));
            Console.WriteLine(Concatenate(true, false));
            Console.WriteLine(Concatenate("so much", "fun"));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


    }
}
