using System;
using System.Collections.Generic;
using System.Text;

namespace MyWalletProject02
{
    public class InputValidation
    {
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
    }
}
