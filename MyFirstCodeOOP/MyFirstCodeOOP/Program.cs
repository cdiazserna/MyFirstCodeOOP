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
                Console.WriteLine("OOP CONCEPTS");
                Console.WriteLine("************");

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
                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = Convert.ToInt32(Console.ReadLine()),
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = Convert.ToBoolean(Console.ReadLine()),
                    Salary = Convert.ToDecimal(Console.ReadLine()),
                };

                Console.WriteLine(salaryEmployee);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
