using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class String_Pgm2
    {
        static void Main()
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();

            string reversed = ReverseString(input);

            Console.WriteLine($"The reverse of '{input}' is: {reversed}");

            Console.ReadLine();
        }
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();

            Array.Reverse(charArray);

            string reversed = new string(charArray);

            return reversed;
        }
    }
}
