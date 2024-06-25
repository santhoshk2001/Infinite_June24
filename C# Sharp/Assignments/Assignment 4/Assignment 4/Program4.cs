using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Scholarship
    {
        public decimal Merit(int marks, decimal fees)
        {
            decimal scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = fees * 0.20m;
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = fees * 0.30m;
            }
            else if (marks > 90)
            {
                scholarshipAmount = fees * 0.50m;
            }

            return scholarshipAmount;
        }
    }

    class Program4
    {
        static void Main(string[] args)
        {
            Scholarship scholarship = new Scholarship();

            int marks = 95;
            decimal fees = 20000m;
            decimal scholarshipAmount = scholarship.Merit(marks, fees);

            Console.WriteLine($"For marks {marks} and fees {fees}, the scholarship amount is {scholarshipAmount}");

            Console.ReadLine();
        }
    }
}
