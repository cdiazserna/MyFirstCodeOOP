using MyFirstCodeOOP.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MyFirstCodeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Date dateObject = new Date(2023, 2, 29);
                Console.WriteLine("****************");
                Console.WriteLine("* OOP CONCEPTS *");
                Console.WriteLine("****************");

                Console.WriteLine("Please put your birth date year:");
                var year = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please put your birth date month:");
                var month = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please put your birth date day:");
                var day = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)));
                Console.WriteLine("");
                Console.WriteLine("******Testing latest implementation*******");
                Console.WriteLine("");

                Console.WriteLine("*******************");
                Console.WriteLine("* SALARY EMPLOYEE *");
                Console.WriteLine("*******************");

                Console.WriteLine("Type your ID");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Type your last name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Are you active?");
                bool isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your salary:");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    Salary = salary,
                };

                //Console.WriteLine(salaryEmployee);

                Console.WriteLine("");

                Console.WriteLine("***********************");
                Console.WriteLine("* COMMISSION EMPLOYEE *");
                Console.WriteLine("***********************");

                Console.WriteLine("Type your ID");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name");
                firstName = Console.ReadLine();

                Console.WriteLine("Type your last name");
                lastName = Console.ReadLine();

                Console.WriteLine("Are you active?");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your commission percentage:");
                float commissionPercentage = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your sales:");
                decimal sales = Convert.ToDecimal(Console.ReadLine());

                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    CommissionPercentage = commissionPercentage,
                    Sales = sales,
                };

                //Console.WriteLine(commissionEmployee);

                Console.WriteLine("");

                Console.WriteLine("***********************");
                Console.WriteLine("* CONTRACTOR EMPLOYEE *");
                Console.WriteLine("***********************");

                Console.WriteLine("Type your ID");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name");
                firstName = Console.ReadLine();

                Console.WriteLine("Type your last name");
                lastName = Console.ReadLine();

                Console.WriteLine("Are you active?");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your number of hours:");
                float hours = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your value per hour:");
                decimal hourValue = Convert.ToDecimal(Console.ReadLine());

                Employee contractorEmployee = new ContractorEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    Hours = hours,
                    HourValue = hourValue,
                };

                //Console.WriteLine(contractorEmployee);

                Console.WriteLine("");

                Console.WriteLine("******************************");
                Console.WriteLine("* BASE & COMMISSION EMPLOYEE *");
                Console.WriteLine("******************************");

                Console.WriteLine("Type your ID");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name");
                firstName = Console.ReadLine();

                Console.WriteLine("Type your last name");
                lastName = Console.ReadLine();

                Console.WriteLine("Are you active?");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your commission percentage:");
                commissionPercentage = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your sales:");
                sales = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter your salary base:");
                decimal salaryBase = Convert.ToDecimal(Console.ReadLine());

                Employee baseComissionEmployee = new BaseCommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    CommissionPercentage = commissionPercentage,
                    Sales = sales,
                    Base = salaryBase
                };

                //Console.WriteLine(baseComissionEmployee);

                EmployeeHelper employeeHelper = new EmployeeHelper(salaryEmployee, commissionEmployee, contractorEmployee, baseComissionEmployee);

                Console.WriteLine($"Total Payroll:...........{employeeHelper.GetPayrollFromActiveEmployees():C2}");

                Console.WriteLine("***********");
                Console.WriteLine("* INVOICE *");
                Console.WriteLine("***********");

                Invoice invoice = new Invoice()
                {
                    Id = 2012015,
                    Description = "iPhone 13",
                    Price = 4500000,
                    Quantity = 2,
                };

                Console.WriteLine(invoice);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
