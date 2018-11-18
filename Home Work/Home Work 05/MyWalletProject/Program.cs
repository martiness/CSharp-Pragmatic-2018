using System;

namespace MyWalletProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("My Wallet Project!");
            Console.WriteLine("Calculate your monthly budget");
            Console.WriteLine();

            // Income Input
            double mySalary = 1000; // InputDoubleValidator("Enter your monthly salary: ");

            // Expenses Input
            double billsExpecenses = 300;// InputDoubleValidator("Enter your monthly Bills Expenses: ");
            double foodExpecenses = 250; // InputDoubleValidator("Enter your monthly Food Expenses: ");
            double transportExpences = 150; // InputDoubleValidator("Enter your monthly Transport Expenses: ");

            // Expenses Report
            //ExpensesReport(mySalary, billsExpecenses, foodExpecenses, transportExpences);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"My Budget Monthly Report");
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total Monthly Income: {mySalary}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            double expensesAmount = billsExpecenses + foodExpecenses + transportExpences;
            Console.WriteLine($"Total Monthly Expenses: {expensesAmount}");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"      Bills: {billsExpecenses}");
            Console.WriteLine($"      Food: {foodExpecenses}");
            Console.WriteLine($"      Transport: {transportExpences}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double savedMoney = mySalary - expensesAmount;
            Console.WriteLine($"Total Monthly Saved: {savedMoney}");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue or any other to quit :-) ");
            Console.ReadKey();
        }

        /// <summary>
        /// Validate Console Input for correct Double values
        /// </summary>
        /// <param name="inputMessage"> Specify input message </param>
        /// <returns></returns>
        public static double InputDoubleValidator(string inputMessage)
        {
            bool IsInputValid = false;
            double inputValue = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{inputMessage}");
                string consoleInput = Console.ReadLine();
                IsInputValid = double.TryParse(consoleInput, out inputValue);
                if (!IsInputValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You have entered invalid value for {inputMessage}!");
                    Console.WriteLine("Please try again ... ");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            while (!IsInputValid);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return inputValue;
        }

        /// <summary>
        /// Validate Console Input for correct Int values
        /// </summary>
        /// <param name="inputMessage"> Specify input message </param>
        /// <returns></returns>
        public static int InputIntValidator(string inputMessage)
        {
            bool IsInputValid = false;
            int inputValue = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{inputMessage}");
                string consoleInput = Console.ReadLine();
                IsInputValid = Int32.TryParse(consoleInput, out inputValue);
                if (!IsInputValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You have entered invalid value for {inputMessage}!");
                    Console.WriteLine("Please try again ... ");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            while (!IsInputValid);
            Console.ForegroundColor = ConsoleColor.White;
            return inputValue;
        }

        /// <summary>
        /// Summing total amount of expenses for set Expense category
        /// </summary>
        /// <param name="expenseType"></param>
        /// <param name="expensesNumber"></param>
        /// <returns></returns>
        public static double ExpensesCategorySumup(string expenseType, int expensesNumber)
        {
            double totalExpensesAmount = 0;
            for (int i = 0; i < expensesNumber; i++)
            {
                Console.Write($"Enter {expenseType} expence #{i + 1}: ");
                totalExpensesAmount = totalExpensesAmount + InputDoubleValidator(expenseType);
            }
            return totalExpensesAmount;
        }

        /// <summary>
        /// Print Expenses Report
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="bills"></param>
        /// <param name="food"></param>
        /// <param name="transport"></param>
        public static void ExpensesReport(double salary, double bills, double food, double transport)
        {
            Console.WriteLine($"My Budget Monthly Report");
            Console.WriteLine();
            Console.WriteLine($"Total Monthly Income: {salary}");
            double expensesAmount = bills + food + transport;
            Console.WriteLine($"Total Monthly Expenses: {salary}");
            Console.WriteLine($"Monthly Bills: {bills}");
            Console.WriteLine($"Monthly Food: {food}");
            Console.WriteLine($"Monthly Transport: {transport}");
            double expensesDifference = salary - expensesAmount;
            Console.WriteLine($"Total Monthly Expenses Difference: {expensesDifference}");
        }
}
}
