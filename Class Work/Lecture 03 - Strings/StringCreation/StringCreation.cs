using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCreation
{
    class StringCreation
    {
        public enum Gender
        {
            Unknown = 0,
            Male = 1,
            Female = 2
        }

        static void Main(string[] args)
        {
            string name = "Martin";
            Console.WriteLine(name);

            name += " Kenoff";
            Console.WriteLine(name);

            // String Concat Examples (...)
            name = String.Concat("Martin", " ", "Kenoff");
            Console.WriteLine(name);
            Console.WriteLine();

            // String Format Examples (...)
            string user = "Martin";
            string city = "Sofia";
            Console.WriteLine(string.Format(
                "My name is {0} and I was born in {1}", user, city));

            decimal salary = 7777.77M;
            Console.WriteLine(string.Format(
                "My salary is {0:C}", salary));

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(string.Format(CultureInfo.GetCultureInfo("bg-BG"),
                "My salary is {0:C}", salary));

            // String Interpolation Examples (...)
            int missedCall = 7;
            string msg = $"You have {missedCall * 10 / 21} missed calls";

            // String Searching Examples (...)
            bool check = msg.Contains("missed");
            Console.WriteLine(check);

            int index = msg.IndexOf("have");
            Console.WriteLine(index);

            // First Index
            int firstIndex = msg.IndexOf("a");
            Console.WriteLine(firstIndex);

            // Last Index
            int lastIndex = msg.IndexOf("a");
            Console.WriteLine(lastIndex);

            // Not Found - 1
            int wrongIndex = msg.IndexOf("giraffe");
            Console.WriteLine(wrongIndex);

            // String Mutations or String Changing 
            Console.WriteLine();
            var output = "It's fun to program";
            output = output.Insert(5, "so much ");
            Console.WriteLine(output);

            // String Allign - Padding 
            Console.WriteLine();
            const byte firstCollumnPadding = 30;
            const byte secondCollumnPadding = 20;
            Console.Write("Name".PadRight(firstCollumnPadding));
            Console.WriteLine("Score".PadLeft(secondCollumnPadding));
            Console.WriteLine(new string ('-', 50));
            Console.Write("Martin".PadRight(firstCollumnPadding));
            Console.WriteLine("9".PadLeft(secondCollumnPadding));
            Console.WriteLine();

            // String Trim
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine().Trim();
            bool isValid = string.IsNullOrEmpty(userName);
            Console.WriteLine($"Hello, ({isValid}) {userName}!");

            string userNameSpace = Console.ReadLine();
            bool isValidSpace = string.IsNullOrWhiteSpace(userNameSpace); // IsNullOrWhiteSpace =  Replace Trim() + IsNullOrEmpty()
            Console.WriteLine($"Hello, ({isValid}) {userNameSpace}!");

            if (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Sorry you need to enter your name!");
            }
            else
            {
                Console.WriteLine($"Hello {userName}!");
            }

            double totalPrice = 0;
            double price = -10;

            if (price >= 0)
            {
                totalPrice += price;
            }
            else
            {
                totalPrice = double.NaN;
            }

            totalPrice = price >= 0 ? totalPrice + price : double.NaN;


            if (price > 100)
            {
                totalPrice += Math.Pow(price, 2);
            }
            else if (price > 50)
            {
                totalPrice += price;
            }
            else
            {
                totalPrice = double.NaN;
            }

            Gender gender = Gender.Unknown;

            switch (gender)     
            {
                case Gender.Unknown:
                    {

                    }
                    break;
                case Gender.Male:
                case Gender.Female:
                    {

                    }
                    break;
                default:
                    break;
            }



            Console.ReadKey();
        }
    }
}
