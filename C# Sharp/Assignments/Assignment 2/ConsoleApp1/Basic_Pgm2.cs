using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Basic_Pgm2
    {
        static void Main()
        {
            Console.Write("Enter a day number (1-7): ");
            int dayNum = int.Parse(Console.ReadLine());

            string dayName = GetDay(dayNum);

            if (dayName != null)
            {
                Console.WriteLine($"The day {dayNum} is: {dayName}");
            }
            else
            {
                Console.WriteLine("Invalid day number.");
            }

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            switch (dayNum)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return null; 
            }
        }
    }
}
