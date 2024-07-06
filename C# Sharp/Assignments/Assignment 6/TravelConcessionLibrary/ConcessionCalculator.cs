using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelConcessionLibrary
{
    public class ConcessionCalculator
    {
        private const double TotalFare = 500.0; // Total fare as a constant

        public static void CalculateConcession(int age)
        {
            if (age <= 5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (age > 60)
            {
                double concessionAmount = TotalFare * 0.30;
                double finalFare = TotalFare - concessionAmount;
                Console.WriteLine($"Senior Citizen - Fare after 30% concession: {finalFare}");
            }
            else
            {
                Console.WriteLine($"Print Ticket Booked - Fare: {TotalFare}");
            }
        }
    }
}
