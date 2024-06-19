using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array_Pgm2
    {
        static void Main()
        {
            int[] marks = new int[10];

            Console.WriteLine("Enter ten marks:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------");
            int total = Total(marks);
            double average = Average(marks);

            int min = MinMarks(marks);
            int max = MaxMarks(marks);

            int[] ascendingMarks = Ascending(marks);

            int[] descendingMarks = Descending(marks);

            Console.WriteLine($"Total marks: {total}");
            Console.WriteLine($"Average marks: {average}");
            Console.WriteLine($"Minimum marks: {min}");
            Console.WriteLine($"Maximum marks: {max}");

            Console.WriteLine("Marks in ascending order:");
            PrintArray(ascendingMarks);

            Console.WriteLine("Marks in descending order:");
            PrintArray(descendingMarks);

            Console.ReadLine();
        }

        static int Total(int[] arr)
        {
            int sum = 0;
            foreach (int mark in arr)
            {
                sum += mark;
            }
            return sum;
        }

        static double Average(int[] arr)
        {
            return (double)Total(arr) / arr.Length;
        }

        static int MinMarks(int[] arr)
        {
            int min = arr[0];
            foreach (int mark in arr)
            {
                if (mark < min)
                {
                    min = mark;
                }
            }
            return min;
        }

        static int MaxMarks(int[] arr)
        {
            int max = arr[0];
            foreach (int mark in arr)
            {
                if (mark > max)
                {
                    max = mark;
                }
            }
            return max;
        }

        static int[] Ascending(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        static int[] Descending(int[] arr)
        {
            int[] descendingArray = new int[arr.Length];
            Array.Copy(arr, descendingArray, arr.Length); 
            Array.Sort(descendingArray);
            Array.Reverse(descendingArray);
            return descendingArray;
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
