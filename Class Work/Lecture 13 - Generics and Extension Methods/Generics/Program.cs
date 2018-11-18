using System;


namespace Generics
{
    #region Hints :) 



    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            var normalClass = new NormalClass();

            normalClass.DoSomething(7.777);

            var genericClass = new GenericClass<string>();

            genericClass.DoSomething(7.ToString());

            string returnValue = genericClass.DoSomethingElse();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
