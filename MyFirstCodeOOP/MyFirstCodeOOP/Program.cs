using System;

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

                Console.WriteLine(salaryEmployee);

                Console.WriteLine("***********************");
                Console.WriteLine("* COMMISSION EMPLOYEE *");
                Console.WriteLine("***********************");

                CommissionEmployee commissionEmployee = new CommissionEmployee();

                Console.WriteLine("Type your ID");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name");
                firstName = Console.ReadLine();

                Console.WriteLine("Type your last name");
                lastName = Console.ReadLine();

                Console.WriteLine("Are you active?");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your commission in percentage:");
                double commissionPercentage = Convert.ToDouble(Console.ReadLine());
                commissionPercentage = commissionEmployee.ConvertPercentage(commissionPercentage);

                Console.WriteLine("Enter your sales:");
                decimal sales = Convert.ToDecimal(Console.ReadLine());

                Employee commissionEmployee1 = new CommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    CommissionPercentage = (float)commissionPercentage,
                    Sales = sales,
                };

                Console.WriteLine(commissionEmployee1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
