using System;
using System.Globalization;

namespace CSharp_HomeWork_02
{
    class SalaryCalculatorV1
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region INPUT
            #region Program Title
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("   Employee Salary Calculator   ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            #endregion

            #region Personal Name
            string firstName = string.Empty;
            bool isCorrectFirstName = false;
            do
            {
                Console.Write("01. Personal Name (Ex: 'Jack'): ");
                // TODO: Uncoment after implementation and remove default values
                //firstName = Console.ReadLine();
                firstName = "Jack";
                if ((firstName.Length > 0) && (IsAllLettersOnly(firstName)))
                    isCorrectFirstName = true;
                else
                {
                    isCorrectFirstName = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Entered Personal Name: '{firstName}' is not correct! Try again ... ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                }
            } while (isCorrectFirstName == false);
            Console.WriteLine();
            #endregion

            #region Family Name
            string lastName = string.Empty;
            bool isCorrectFamilyName = false;
            do
            {
                Console.Write("02. Family Name ('Ex: Daniels'): ");
                // TODO: Uncoment after implementation and remove default values
                //lastName = Console.ReadLine();
                lastName = "Daniels";
                if ((lastName.Length > 0) && (IsAllLettersOnly(lastName)))
                    isCorrectFamilyName = true;
                else
                {
                    isCorrectFamilyName = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Entered Family Name: '{lastName}' is not correct! Try again ... ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                }
            } while (isCorrectFamilyName == false);

            Console.WriteLine();
            #endregion

            #region Personal ID  
            string employeeId = string.Empty;
            bool isCorrectId = false;
            do
            {
                Console.Write("03. Personal ID (Ex: '8012056818'): ");
                // TODO: Uncoment after implementation and remove default values
                // employeeId = Console.ReadLine();
                employeeId = "8212106644";
                if ((employeeId.ToString().Length == 10) && IsAllDigitsOnly(employeeId))
                    isCorrectId = true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Entered Employee ID: '{employeeId}' is not correct! Try again ... ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    isCorrectId = false;
                }

            } while (isCorrectId == false);
            Console.WriteLine();
            #endregion

            #region Address
            string address = string.Empty;
            bool isCorrectAddress = false;
            do
            {
                Console.Write("04. Address (Ex: 'bul. Bulgaria No: 1'): ");
                // TODO: Uncoment after implementation and remove default values
                // address = Console.ReadLine();
                address = "bul. Bulgaria No: 1";
                if (address.Length > 4)
                    isCorrectAddress = true;
                else
                {
                    isCorrectAddress = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Entered Address: '{address}' is not correct! Try again ... ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                }
            } while (isCorrectAddress == false);
            Console.WriteLine();
            #endregion

            #region City
            string city = string.Empty;
            bool isCorrectCity = false;
            do
            {
                Console.Write("05. City (Ex: 'Sofia'): ");
                // TODO: Uncoment after implementation and remove default values
                // city = Console.ReadLine();
                city = "Sofia";
                if ((city.Length > 4) && IsAllLettersOnly(city))
                    isCorrectCity = true;
                else
                {
                    isCorrectCity = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Entered City: '{city}' is not correct! Try again ... ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                }
            } while (isCorrectCity == false);
            Console.WriteLine();
            #endregion

            #region Municipality
            string municipality = string.Empty;
            bool isCorrectMunicipality = false;
            do
            {
                Console.Write("06. Municipality (Ex: 'Triaditza'): ");
                // TODO: Uncoment after implementation and remove default values
                // municipality = Console.ReadLine();
                municipality = "Triaditza";
                if ((municipality.Length > 4) && IsAllLettersOnly(municipality))
                    isCorrectMunicipality = true;
                else
                {
                    isCorrectMunicipality = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Entered Municipality: '{municipality}' is not correct! Try again ... ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                }
            } while (isCorrectMunicipality == false);
            Console.WriteLine();
            #endregion

            #region Gross Salary
            string grossSalary = string.Empty;
            bool isCorrectSalary = false;
            do
            {
                Console.Write("07. Gross Salary (Ex: '100' ): ");
                // TODO: Uncoment after implementation and remove default values
                // grossSalary = Console.ReadLine();
                grossSalary = "100";
                if ((grossSalary.ToString().Length > 2 && grossSalary.ToString().Length < 7) && IsAllDigitsOnly(grossSalary))
                    isCorrectSalary = true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Entered Gross Salary: '{grossSalary}' is not correct! Try again ... ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    isCorrectSalary = false;
                }

            } while (isCorrectSalary == false);
            Console.WriteLine();
            #endregion

            #region Work Experience
            string workExperience = string.Empty;
            bool isCorrectExperience = false;
            do
            {
                Console.Write("08. Work Experience (Ex: '1.9' years): ");
                // TODO: Uncoment after implementation and remove default values
                // workExperience = Console.ReadLine();
                workExperience = "2.9";
                if (IsRealNumber(workExperience))
                    isCorrectExperience = true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Entered Work Experience: '{workExperience}' is not correct! Try again ... ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    isCorrectExperience = false;
                }

            } while (isCorrectExperience == false);
            Console.WriteLine();
            #endregion
            #endregion

            #region PRINT INPUT
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("   Employee Information Summary   ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"01. Personal Name: {firstName}");
            Console.WriteLine($"02. Family Name: {lastName}");
            Console.WriteLine($"03. Personal ID: {employeeId}");
            Console.WriteLine($"04. Address: {address}");
            Console.WriteLine($"05. City: {city}");
            Console.WriteLine($"06. Municipality: {municipality}");
            Console.WriteLine($"07. Gross Salary: {grossSalary}");
            Console.WriteLine($"08. Work Experience: {workExperience}");
            Console.WriteLine("Press any key to continue with calculations ...");
            Console.ReadKey();
            #endregion

            #region SALARY CALCULATIONS

            #region Gross Salary Indexation
            string workExperienceIndex = workExperience.ToString(CultureInfo.InvariantCulture);
            string[] parts = workExperienceIndex.Split('.');
            int salaryIndex = int.Parse(parts[0]);
            // TODO: Calculate indexing for every year 
            // 1st year 100 + (100 * (0,6 / 100)) 
            // 2nd year 1st year salary + (1st year salary * (0,6 / 100)) 
            decimal yearlySalaryIndex = Convert.ToDecimal(salaryIndex * 0.6); 
            decimal indexedGrossSalary = Convert.ToDecimal(grossSalary) + yearlySalaryIndex;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Total Gross Salary for {workExperience} years of work experience is {indexedGrossSalary:C}");
            Console.ReadKey();
            #endregion

            #region Net Salary Calculation
            decimal pensionFund = 0;
            decimal pensionFundIndex = Convert.ToDecimal(6.58/100);
            decimal totalGrossSalary = Convert.ToDecimal(grossSalary);
            decimal notIndexedGrossSalary = 0;
           
            if (totalGrossSalary <= 2600)
            {
                pensionFund = totalGrossSalary * pensionFundIndex;
            }
            else
            {
                notIndexedGrossSalary = totalGrossSalary - 2600;
                pensionFund = 2600 * pensionFundIndex;
            }

            decimal ozmFund = 0;
            decimal ozmFundIndex = Convert.ToDecimal(1.4);
            #endregion

            #endregion
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
        /// Verify value is a real number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsRealNumber(string input)
        {
            double realNumber;
            bool isRealNumber = Double.TryParse(input,
                                                System.Globalization.NumberStyles.Any,
                                                System.Globalization.NumberFormatInfo.InvariantInfo,
                                                out realNumber);
            return isRealNumber;
        }

    }
}
