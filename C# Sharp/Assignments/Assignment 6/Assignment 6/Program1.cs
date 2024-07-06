using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelConcessionLibrary;
namespace Assignment_6
{
    class Program1
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 7, 2, 30 };

            var result = numbers
                .Select(n => new { Number = n, Square = n * n })  // Compute squares
                .Where(x => x.Square > 20)  // Filter squares greater than 20
                .ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Number} - {item.Square}");
            }
            Console.Read();
        }
    }
}
