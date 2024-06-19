using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array_Pgm3
    {
        static void Main()
        {
            int[] source = { 1, 2, 3, 4, 5 };

            int[] destination = new int[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }

            Console.WriteLine("Original Array:");
            PrintArray(source);

            Console.WriteLine("\nCopied Array:");
            PrintArray(destination);

            Console.ReadLine();
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
