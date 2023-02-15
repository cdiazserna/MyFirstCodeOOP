using System;

namespace MyFirstCodeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ////Date dateObject = new Date(2023, 2, 29);
                //Console.WriteLine("OOP CONCEPTS");
                //Console.WriteLine("************");

                //Console.WriteLine("Please put your year:");
                //var year = Console.ReadLine();
                //Console.WriteLine("");
                //Console.WriteLine("Please put your month:");
                //var month = Console.ReadLine();
                //Console.WriteLine("");
                //Console.WriteLine("Please put your day:");
                //var day = Console.ReadLine();
                //Console.WriteLine("");
                //Console.WriteLine(new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)));

                Employee employee1 = new SalaryEmployee()
                {
                    Id = 1,
                    FirstName = "Pancho",
                    LastName = "Villa",
                    BirthDate = new Date(1945, 2, 20),
                    HiringDate = new Date(2022, 1, 2),
                    IsActive = true,
                    Salary = 100000.55M
                };

                Console.WriteLine(employee1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
