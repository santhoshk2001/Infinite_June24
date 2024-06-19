using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class String_Pgm3
    {
        static void Main()
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            if (word1 == word2)
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are the same.");
            }
            else
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are different.");
            }

            Console.ReadLine();
        }
    }
}
