using System;

namespace MyFirstCodeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("OOP CONCEPTS");
                Console.WriteLine("************");
                Console.WriteLine(new Date(2023, 2, 29));
                Console.WriteLine(new Date(2000, 3, 2));
                Console.WriteLine(new Date(2000, 2, 44));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
