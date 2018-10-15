using System;
using System.Text;

namespace CSharp_HomeWork_01
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            #region Menu
            //TODO: Add Menu and Navigaition logic
            //bool repeat = false;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Home Work - CSharp .Net Pragmatic - 03.10.2018");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tasks List: ");
            Console.WriteLine("(1) Task #1: Variables types ");
            Console.WriteLine("(2) Task #2: Escaping signs");
            Console.WriteLine("(3) Task #3: Salary calculation");
            Console.WriteLine("(4) Task #4: Math examples");
            Console.WriteLine("(5) Task #5: Values exchange");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please enter number between 1-5 to review respective Task: ");
            Console.OutputEncoding = Encoding.UTF8;
            string userChoice = Console.ReadLine();
            Console.WriteLine();

            int taskNumber = 1;
            if (int.TryParse(userChoice, out taskNumber))
            {
                Console.WriteLine($"You have choosen to review task: {taskNumber}");
            }
            else
            {
                Console.WriteLine("You have entered invalid value. Please try again");
            }
            #endregion

            #region Tasks
            switch (taskNumber)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("1. Изберете и запишете следните стойности в променливи от оптималният за тях тип:");
                        Console.WriteLine("4, true, 1523555666, -55.25, 7534888321, 512355215.555, 4.123456789012345678901234, c, 'Текст'");
                        Console.WriteLine();

                        byte shortNumber = 4;
                        bool condition = true;
                        int number = 1523555666;
                        float sfloatNumber = -55.25f;
                        long longNumber = 7534888321;
                        double ldoubleNumber = 512355215.555;
                        float sdoubleNumber = 4.123456789012345678901234f;
                        char charSign = 'c';
                        string textValue = "Текст";

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Short Number: {shortNumber}");
                        Console.WriteLine($"Boolean Condition: {condition}");
                        Console.WriteLine($"Regular Integer Number: {number}");
                        Console.WriteLine($"Signed Float Number: {sfloatNumber}");
                        Console.WriteLine($"Long Integer Number: {longNumber}");
                        Console.WriteLine($"Long Double Number: {ldoubleNumber}");
                        Console.WriteLine($"Short Double Number: {sdoubleNumber}");
                        Console.WriteLine($"Char Sign: {charSign}");
                        Console.WriteLine($"String Value: {textValue}");

                        Console.ForegroundColor = ConsoleColor.White;
                        //ConsoleKeyInfo keyPressed;
                        //keyPressed = Console.ReadKey();
                        Console.WriteLine("Press any key to retun main menu");
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        string escapeText = "The \"quick brown\\\" fox jumped/ over \\\\ the river. \"\"Another\" " +
                                          "\nsentence on a new \'line\".";

                        Console.WriteLine($"2.Декларирайте променлива и я инициализирайте със следната стойност: \n{escapeText}");
                        Console.WriteLine("Отпечатайте резултата в конзолата.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(escapeText);

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press any key to retun to quit");
                        Console.ReadKey();
                    }
                    break;

                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("3.Напишете програма, чиято цел е да изчисли заплата за 5 години на служител в дадена компания.");
                        Console.WriteLine("Програмата приема пита потребителя за месечната заплата на служителя.");

                        Console.Write("Employee Name: ");
                        string employeeName = Console.ReadLine();
                        Console.Write("Employee Monthly Salary: ");
                        double employeeMonthlySalary = 1;
                        string employeeSalary = Console.ReadLine();
                        if (double.TryParse(employeeSalary, out employeeMonthlySalary))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Employee name: {employeeName}");
                            Console.WriteLine($"Employee monthly salary: {employeeMonthlySalary}");
                            Console.WriteLine($"Employee yearly salary: {employeeMonthlySalary * 12}");
                            Console.WriteLine($"Employee salary for 5 years: {employeeMonthlySalary * 60}");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Press any key to retun to quit");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You have entered invalid salary. Please try again");
                        }
                    }
                    break;

                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("4.Напишете програма, която решава уравненията от слайд 23 от презентацията използвайте посочените примерни методи от класа Math.");

                        string[] example = new string[6];
                        example[0] = "Example #1: 2*(10(power(|x|)) / (x + (sqr(5)))";
                        example[1] = "Example #2: (x(power(x))/2*x)-(|x|/2)";
                        example[2] = "Example #3: 5*x*sqrt(100) + (x/2)*x";
                        example[3] = "Example #4: (2x + x)(power(1/3))";
                        example[4] = "Example #5: sin(x)/|x| + 10(power(x))";
                        example[5] = "Example #6: x + ((10 power 2x) / (cos(x))) + (asb(100 - sqr(x))";

                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(example[0]);
                        Console.WriteLine(example[1]);
                        Console.WriteLine(example[2]);
                        Console.WriteLine(example[3]);
                        Console.WriteLine(example[4]);
                        Console.WriteLine(example[5]);

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Enter value for X: ");
                        string input = Console.ReadLine();
                        double[] result = new double[6]; 

                        if (double.TryParse(input, out double parameter))
                        {
                            result[0] = 2 * (Math.Pow(10, Math.Abs(parameter))) / (parameter + Math.Pow(5, 2));
                            result[1] = (Math.Pow(parameter, 10)/(2 * parameter)) - (Math.Abs(parameter)/2);
                            result[2] = (5 * parameter * Math.Sqrt(100)) + ((parameter / 2) * parameter);
                            result[3] = Math.Pow(((2 * parameter) + parameter), 1.0 / 3.0);
                            result[4] = (Math.Sin(parameter) / Math.Abs(parameter)) + Math.Pow(10, parameter);
                            result[5] = parameter * ((Math.Pow(10, 2 * parameter))/(Math.Cos(parameter))) + (Math.Abs(100 - Math.Pow(parameter, 2)));

                            for (int i = 0; i < result.Length; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"{example[i]} ");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"Result: {result[i]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You have entered invalid value!");
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press any key to retun to quit");
                        Console.ReadKey();
                    }
                    break;

                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("5*. Опитайте се да напишете програма, която разменя стойностите на две целочислени променливи, без да използва трета.");

                        int firstValue = 12345;
                        int secondValue = 98765;

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Initial values before exchange: ");
                        Console.WriteLine($"First Value: {firstValue} \nSecond Value: {secondValue}");

                        secondValue = secondValue - firstValue;
                        firstValue = firstValue + secondValue;
                        secondValue = firstValue - secondValue;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Result values after exchange: ");
                        Console.WriteLine($"First Value: {firstValue} \nSecond Value: {secondValue}");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press any key to retun to quit");
                        Console.ReadKey();
                    }
                    break;

                default:
                break;
            }
            #endregion
        }

    }
}
