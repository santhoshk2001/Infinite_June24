using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc4
{
    // Define a delegate that takes two integers and returns an integer
    delegate int CalDelegate(int x, int y);

    class CalculatorApp
    {
        static void Main()
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------");
            CalDelegate add = new CalDelegate(Add);
            CalDelegate subtract = new CalDelegate(Sub);
            CalDelegate multiply = new CalDelegate(Mul);

            Console.WriteLine($"Addition: {num1} + {num2} = {add(num1, num2)}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {subtract(num1, num2)}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {multiply(num1, num2)}");

            Console.Read();
        }

        // Method for addition
        static int Add(int x, int y)
        {
            return x + y;
        }

        // Method for subtraction
        static int Sub(int x, int y)
        {
            return x - y;
        }

        // Method for multiplication
        static int Mul(int x, int y)
        {
            return x * y;
        }
    }
}
