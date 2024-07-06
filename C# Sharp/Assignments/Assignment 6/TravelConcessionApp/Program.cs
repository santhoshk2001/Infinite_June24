using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelConcessionLibrary;
namespace TravelConcessionApp
{
    class Program
    {
        private const double TotalFare = 500.0;

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Display Concession Based on Age");
                Console.WriteLine("2. Display Total Fare");
                Console.WriteLine("3. Exit");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HandleConcessionCalculation();
                        Console.WriteLine("-------------------------------------");
                        break;
                    case "2":
                        Console.WriteLine($"Total Fare: {TotalFare}");
                        Console.WriteLine("-------------------------------------");
                        break;
                    case "3":
                        return; 
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        static void HandleConcessionCalculation()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"Name: {name}");
                ConcessionCalculator.CalculateConcession(age);
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid number.");
            }
        }
    }
}
