using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class String_Pgm1
    {
        static void Main()
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();

            int length = input.Length;

            Console.WriteLine($"The length of the word '{input}' is: {length}");

            Console.ReadLine();
        }
    }
}
