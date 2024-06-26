using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc2
{
    class Program3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter an integer: ");
                int number = int.Parse(Console.ReadLine());
                CheckIfNegative(number);
                Console.WriteLine("The number is non-negative.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }
            Console.Read();
        }

        static void CheckIfNegative(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number cannot be negative.");
            }
        }
    }
}
