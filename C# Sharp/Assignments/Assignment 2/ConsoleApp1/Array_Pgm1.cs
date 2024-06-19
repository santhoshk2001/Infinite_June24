using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array_Pgm1
    {
        static void Main()
        {
            int[] nums = {0,1,2,3,4,5,6,7,8,9};

            double avg = Average(nums);

            int min = Minimum(nums);
            int max = Maximum(nums);

            Console.WriteLine($"Average value of Array elements: {avg}");
            Console.WriteLine($"Minimum value in the array: {min}");
            Console.WriteLine($"Maximum value in the array: {max}");

            Console.ReadLine();
        }

        static double Average(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }

        static int Minimum(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        static int Maximum(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
