using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthenticationManager manager = new AuthenticationManager();

            manager.Login();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
