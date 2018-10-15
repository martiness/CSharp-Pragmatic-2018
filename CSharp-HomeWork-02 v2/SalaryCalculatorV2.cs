using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HomeWork_02_v2
{
    public enum Employee
    {
        PersonalName = 0,
        FamilyName = 1,
        PersonalId = 2,
        Address = 3,
        City = 4,
        Manicipality = 5,
        GrossSalary = 6,
        WorkExperiance = 7
    }
       
    class SalaryCalculatorV2
    {
        static void Main(string[] args)
        {
            Employee employee = Employee.PersonalName;
            string firstName = string.Empty;
            string lastName = string.Empty;
            string employeeId = string.Empty;
            string address = string.Empty;
            string city = string.Empty;
            string municipality = string.Empty;
            string grossSalary = string.Empty;
            string workExperience = string.Empty;

            switch (employee)
            {
                case Employee.PersonalName:
                    {
                        Console.Write(">> Personal Name (Ex: 'Jack'): ");
                        firstName = Console.ReadLine();
                    };
                    break;

                case Employee.FamilyName:
                    {
                        Console.Write(">> Family Name ('Ex: Danields'): ");
                        lastName = Console.ReadLine();
                    };
                    break;

                case Employee.PersonalId:
                    {
                        Console.Write(">> Personal ID (Ex: '8012056818'): ");
                        employeeId = Console.ReadLine();
                    };
                    break;

                case Employee.Address:
                    {
                        Console.Write(">> Person Address (Ex: 'bul. Bulgaria No: 1'): ");
                        address = Console.ReadLine();
                    };
                    break;

                case Employee.City:
                    {
                        Console.Write(">> Person City (Ex: 'Sofia'): ");
                        city = Console.ReadLine();
                    };
                    break;

                case Employee.Manicipality:
                    {

                    };
                    break;

                case Employee.GrossSalary:
                    {

                    };
                    break;

                case Employee.WorkExperiance:
                    {

                    };
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Verify values contains only digits input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsAllDigitsOnly(string input)
        {
            foreach (var c in input)
            {
                //if (c < '0' || c > '9')
                //if (Regex.IsMatch(input, @"^[0-9]+$"))
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Verify values contains only letters input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns> 
        public static bool IsAllLettersOnly(string input)
        {
            foreach (var c in input)
            {
                //if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// TODO: Implement input Verification method for all fields. 
        /// </summary>
        /// <param name="isInputCorrect"></param>
        /// <param name="input"></param>
        /// <param name="employee"></param>
        public static void inputVerification(bool isInputCorrect = false, string input = "", Enum employee = null)
        {
            do
            {
                // TODO: Verification for Not Emply 
                // TODO: Option to do verification for Only Letters, Mix or Only Digits
                if (input.Length > 0)
                {
                    if (IsAllLettersOnly(input))
                    {
                        isInputCorrect = true;
                    }
                }

                else
                {
                    isInputCorrect = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Entered {employee} is not correct! Try again ... ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                }
            } while (isInputCorrect == false);
        }
    }
}
