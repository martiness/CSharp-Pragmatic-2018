using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // we will be able to call DoSomething() on anything
            // because its an extension method for Object class
            // which is the ultimate parent of every single class

            3.DoSomething();

            "dsadsad".DoSomething();

            List<string> list = new List<string>();
            list.DoSomething();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
