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

                Console.WriteLine("Please put your year:");
                var year = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please put your month:");
                var month = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please put your day:");
                var day = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)));

                Console.WriteLine("******Testing latest implementation*******");

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = 1000,
                    FirstName = "Maria",
                    LastName = "Posada",
                    BirthDate = new Date(1950, 2, 5),
                    HiringDate = new Date(2022, 12, 31),
                    IsActive = true,
                    Salary = 200000.34M                            
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
