using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program2
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of words separated by spaces:");
            string input = Console.ReadLine();

            List<string> words = ParseInput(input);

            words
                .Where(word => word.StartsWith("a") && word.EndsWith("m"))
                .ToList()
                .ForEach(word => Console.WriteLine(word));

            Console.Read();
        }

        static List<string> ParseInput(string input)
        {
            return input.Split(' ').ToList();
        }
    }
}
