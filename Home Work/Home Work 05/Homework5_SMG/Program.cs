using System;


namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Wallet wallet = new Wallet();
            wallet.Load("wallet.dat");

            // hint you can use the same approach as in the chess or tic-tac-toe projects
            // e.g infinite cycle that asks for a text command (ex. add expense, add income, etc.)

            // do some work with the wallet
            // 1) add expense or income
            // 2) get statistics
            // 3) etc.

            // before we quit we should save the current state of our objects to file
            wallet.Save("wallet.dat");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
