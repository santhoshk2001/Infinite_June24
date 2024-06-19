using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Basic_Pgm1
    {
        static void Main()
        {
            Console.WriteLine("Enter two integers:");

            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            if (num1 == num2)
            {
                int res = 3 * sum;
                Console.WriteLine($"numbers are same, triple of their sum is: {res}");
            }
            else
            {
                Console.WriteLine($"Sum of the two integers is: {sum}");
            }

            Console.ReadLine();
        }
    }
}
