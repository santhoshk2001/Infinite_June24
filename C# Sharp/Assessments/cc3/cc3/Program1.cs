using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3
{
    class Cricket
    {
        public void Pointscalculation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];
            int sum = 0;

            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write("Enter the score for match {0}: ", i + 1);
                scores[i] = int.Parse(Console.ReadLine());
                sum = sum + scores[i]; // Calculating sum of scores
            }

            double avg = (double)sum / no_of_matches; // Calculating the average

            Console.WriteLine("Sum of the scores: " + sum);
            Console.WriteLine("Average of the scores: " + avg);
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Cricket cricket = new Cricket();

            Console.Write("Enter the number of matches: ");
            int no_of_matches = int.Parse(Console.ReadLine());

            cricket.Pointscalculation(no_of_matches);

            Console.Read();
        }
    }
}
