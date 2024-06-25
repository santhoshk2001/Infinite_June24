using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program2
    {
        static int Count_No_of_Occurrences(string str, char letter)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (ch == letter)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string userString = Console.ReadLine();

            Console.Write("Enter the letter to count: ");
            char letterToCount;
            if (!char.TryParse(Console.ReadLine(), out letterToCount))
            {
                Console.WriteLine("Please enter a single character for the letter to count.");
                return;
            }

            int occurrences = Count_No_of_Occurrences(userString, letterToCount);

            Console.WriteLine($"The letter '{letterToCount}' appears {occurrences} times in the string.");

            Console.ReadLine();
        }
    }
}
