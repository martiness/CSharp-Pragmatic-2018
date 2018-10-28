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
                // TODO: Uncomment after implementation and remove default values
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
                // TODO: Uncomment after implementation and remove default values
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
                // TODO: Uncomment after implementation and remove default values
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
                // TODO: Uncomment after implementation and remove default values
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
                // TODO: Uncomment after implementation and remove default values
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
                // TODO: Uncomment after implementation and remove default values
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
                // TODO: Uncomment after implementation and remove default values
                // grossSalary = Console.ReadLine();
                grossSalary = "6500";
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
                // TODO: Uncomment after implementation and remove default values
                // workExperience = Console.ReadLine();
                workExperience = "15.9";
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue with calculations ...");
            Console.ReadKey();
            #endregion

            #region SALARY CALCULATIONS

            #region Gross Salary Indexation
            string workExperienceIndex = workExperience.ToString(CultureInfo.InvariantCulture);
            string[] parts = workExperienceIndex.Split('.'); // Split value before and after decimal sign
            int workExperienceFullYears = int.Parse(parts[0]); // Extract only value before decimal sign, to get only full years

            double increaseSalaryPercent = 0.6;
            decimal indexedGrossSalary = Convert.ToDecimal(grossSalary);
            for (int i = 1; i <= workExperienceFullYears; i++)
            {
                indexedGrossSalary = indexedGrossSalary * Convert.ToDecimal( 1 + increaseSalaryPercent/100);
            }
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Total Gross Salary for {workExperience} years of work experience is {indexedGrossSalary:C}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue with calculations ...");
            Console.ReadKey();
            #endregion

            #region Monthly Net Salary Calculation
            decimal maxTaxableSalary = 2600;
            decimal totalGrossSalary = Convert.ToDecimal(grossSalary);
            decimal totalNetSalary = 0;
            decimal salaryDeduction = 0;
            decimal pensionFund = 0;
            decimal pensionFundIndex = Convert.ToDecimal(6.58/100);
            decimal ozmFund = 0;
            decimal ozmFundIndex = Convert.ToDecimal(1.4/100);
            decimal unemploymentFund = 0;
            decimal unemploymentFundIndex = Convert.ToDecimal(0.4/100);
            decimal dzpoFund = 0;
            decimal dzpoFundIndex = Convert.ToDecimal(2.2/100);
            decimal healthFund = 0;
            decimal healthFundIndex = Convert.ToDecimal(3.2/100);
            decimal ddflFund = 0;
            decimal ddflFundIndex = Convert.ToDecimal(10.0/100);
           
            if (totalGrossSalary <= maxTaxableSalary)
            {
                pensionFund = maxTaxableSalary * pensionFundIndex;
                ozmFund = maxTaxableSalary * ozmFundIndex;
                unemploymentFund = maxTaxableSalary * unemploymentFundIndex;
                dzpoFund = maxTaxableSalary * dzpoFundIndex;
                healthFund = maxTaxableSalary * healthFundIndex;
                salaryDeduction = pensionFund + ozmFund + unemploymentFund + dzpoFund + healthFund;
                totalNetSalary = totalGrossSalary - salaryDeduction;
            }
            else
            {
                pensionFund = totalGrossSalary * pensionFundIndex;
                ozmFund = totalGrossSalary * ozmFundIndex;
                unemploymentFund = totalGrossSalary * unemploymentFundIndex;
                dzpoFund = totalGrossSalary * dzpoFundIndex;
                healthFund = totalGrossSalary * healthFundIndex;
                ddflFund = totalGrossSalary * ddflFundIndex;
                salaryDeduction = pensionFund + ozmFund + unemploymentFund + dzpoFund + healthFund + ddflFund;
                totalNetSalary = totalGrossSalary - salaryDeduction;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Employee Salary Summary:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Employee Gross Salary:{totalGrossSalary:C}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Employee Net Salary: {totalNetSalary:C}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Employee Salary Deduction: {salaryDeduction:C}");
            Console.WriteLine($"-- Pension Fund Deduction: {pensionFund:C}");
            Console.WriteLine($"-- OZM Fund Deduction: {ozmFund:C}");
            Console.WriteLine($"-- Unemployment Fund Deduction: {unemploymentFund:C}");
            Console.WriteLine($"-- DZPO Fund Deduction: {dzpoFund:C}");
            Console.WriteLine($"-- Health Fund Deduction: {healthFund:C}");
            Console.WriteLine($"-- DDFL Fund Deduction: {ddflFund:C}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue with calculations ...");
            Console.ReadKey();
            #endregion

            #region #3 Yearly Gross Salary Calculation
            decimal yearlyIndexedGrossSalary = 12 * GetSalary(workExperienceFullYears, Convert.ToDecimal(grossSalary), increaseSalaryPercent);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Total Yearly Gross Salary for {workExperience} years of work experience is {yearlyIndexedGrossSalary:C}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue with calculations ...");
            Console.ReadKey();
            #endregion

            #region #4 Yearly Net Salary Calculation
            
            if (indexedGrossSalary <= maxTaxableSalary)
            {
                pensionFund = maxTaxableSalary * pensionFundIndex;
                ozmFund = maxTaxableSalary * ozmFundIndex;
                unemploymentFund = maxTaxableSalary * unemploymentFundIndex;
                dzpoFund = maxTaxableSalary * dzpoFundIndex;
                healthFund = maxTaxableSalary * healthFundIndex;
                salaryDeduction = pensionFund + ozmFund + unemploymentFund + dzpoFund + healthFund;
                totalNetSalary = indexedGrossSalary - salaryDeduction;
            }
            else
            {
                pensionFund = indexedGrossSalary * pensionFundIndex;
                ozmFund = indexedGrossSalary * ozmFundIndex;
                unemploymentFund = indexedGrossSalary * unemploymentFundIndex;
                dzpoFund = indexedGrossSalary * dzpoFundIndex;
                healthFund = indexedGrossSalary * healthFundIndex;
                ddflFund = indexedGrossSalary * ddflFundIndex;
                salaryDeduction = pensionFund + ozmFund + unemploymentFund + dzpoFund + healthFund + ddflFund;
                totalNetSalary = indexedGrossSalary - salaryDeduction;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Employee Salary Summary:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Employee Gross Salary:{totalGrossSalary:C}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Employee Net Salary: {totalNetSalary:C}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Employee Salary Deduction: {salaryDeduction:C}");
            Console.WriteLine($"-- Pension Fund Deduction: {pensionFund:C}");
            Console.WriteLine($"-- OZM Fund Deduction: {ozmFund:C}");
            Console.WriteLine($"-- Unemployment Fund Deduction: {unemploymentFund:C}");
            Console.WriteLine($"-- DZPO Fund Deduction: {dzpoFund:C}");
            Console.WriteLine($"-- Health Fund Deduction: {healthFund:C}");
            Console.WriteLine($"-- DDFL Fund Deduction: {ddflFund:C}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue with calculations ...");
            Console.ReadKey();

            decimal yearlyIndexedNetSalary = 12 * totalNetSalary;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Total Yearly Net Salary for {workExperience} years of work experience is {yearlyIndexedNetSalary:C}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue with calculations ...");
            Console.ReadKey();
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

        /// <summary>
        /// Gets Salary Indexation Recursively .
        /// </summary>
        /// <param name="years">The years.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="increasePercent">The increase percent.</param>
        /// <returns></returns>
        public static decimal GetSalary(int years, decimal salary, double increasePercent)
        {
            if (years < 1)
            {
                return salary;
            }
            else
            {
                salary *= Convert.ToDecimal(1 + increasePercent / 100);
                salary = GetSalary(--years, salary, increasePercent);
            }
            return salary;
        }

        public static void taxRate()
        {
            //TO DO: Calculate taxRate here
        }

    }
}
