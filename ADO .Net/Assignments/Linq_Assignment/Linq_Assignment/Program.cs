using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Assignment
{
    class Emp
    {
        public int EID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Job { get; set; }
        public DateTime BD { get; set; }
        public DateTime JD { get; set; }
        public string Loc { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Emp> empList = new List<Emp>
        {
            new Emp { EID = 1001, FName = "Malcolm", LName = "Daruwalla", Job = "Manager", BD = new DateTime(1984, 11, 16), JD = new DateTime(2011, 6, 8), Loc = "Mumbai" },
            new Emp { EID = 1002, FName = "Asdin", LName = "Dhalla", Job = "AsstManager", BD = new DateTime(1984, 8, 20), JD = new DateTime(2012, 7, 7), Loc = "Mumbai" },
            new Emp { EID = 1003, FName = "Madhavi", LName = "Oza", Job = "Consultant", BD = new DateTime(1987, 11, 14), JD = new DateTime(2015, 4, 12), Loc = "Pune" },
            new Emp { EID = 1004, FName = "Saba", LName = "Shaikh", Job = "SE", BD = new DateTime(1990, 6, 3), JD = new DateTime(2016, 2, 2), Loc = "Pune" },
            new Emp { EID = 1005, FName = "Nazia", LName = "Shaikh", Job = "SE", BD = new DateTime(1991, 3, 8), JD = new DateTime(2016, 2, 2), Loc = "Mumbai" },
            new Emp { EID = 1006, FName = "Amit", LName = "Pathak", Job = "Consultant", BD = new DateTime(1989, 11, 7), JD = new DateTime(2014, 8, 8), Loc = "Chennai" },
            new Emp { EID = 1007, FName = "Vijay", LName = "Natrajan", Job = "Consultant", BD = new DateTime(1989, 12, 2), JD = new DateTime(2015, 6, 1), Loc = "Mumbai" },
            new Emp { EID = 1008, FName = "Rahul", LName = "Dubey", Job = "Associate", BD = new DateTime(1993, 11, 11), JD = new DateTime(2014, 11, 6), Loc = "Chennai" },
            new Emp { EID = 1009, FName = "Suresh", LName = "Mistry", Job = "Associate", BD = new DateTime(1992, 8, 12), JD = new DateTime(2014, 12, 3), Loc = "Chennai" },
            new Emp { EID = 1010, FName = "Sumit", LName = "Shah", Job = "Manager", BD = new DateTime(1991, 4, 12), JD = new DateTime(2016, 1, 2), Loc = "Pune" }
        };

            // 1. Display a list of all the employee who have joined before 1/1/2015
            Console.WriteLine("1. Employees who joined before 1/1/2015:");
            var query1 = empList.Where(e => e.JD < new DateTime(2015, 1, 1));
            foreach (var emp in query1)
            {
                Console.WriteLine($"{emp.FName} {emp.LName}");
            }

            // 2. Display a list of all the employee whose date of birth is after 1/1/1990
            Console.WriteLine("\n2. Employees born after 1/1/1990:");
            var query2 = empList.Where(e => e.BD > new DateTime(1990, 1, 1));
            foreach (var emp in query2)
            {
                Console.WriteLine($"{emp.FName} {emp.LName}");
            }

            // 3. Display a list of all the employee whose designation is Consultant and Associate
            Console.WriteLine("\n3. Employees with designation Consultant and Associate:");
            var query3 = empList.Where(e => e.Job == "Consultant" || e.Job == "Associate");
            foreach (var emp in query3)
            {
                Console.WriteLine($"{emp.FName} {emp.LName} - {emp.Job}");
            }

            // 4. Display total number of employees
            Console.WriteLine($"\n4. Total number of employees: {empList.Count}");

            // 5. Display total number of employees belonging to "Chennai"
            Console.WriteLine($"\n5. Total number of employees in Chennai: {empList.Count(e => e.Loc == "Chennai")}");

            // 6. Display highest employee id from the list
            Console.WriteLine($"\n6. Highest employee ID: {empList.Max(e => e.EID)}");

            // 7. Display total number of employee who have joined after 1/1/2015
            Console.WriteLine($"\n7. Number of employees who joined after 1/1/2015: {empList.Count(e => e.JD > new DateTime(2015, 1, 1))}");

            // 8. Display total number of employee whose designation is not "Associate"
            Console.WriteLine($"\n8. Number of employees whose designation is not Associate: {empList.Count(e => e.Job != "Associate")}");

            // 9. Display total number of employee based on City
            Console.WriteLine("\n9. Number of employees based on City:");
            var query9 = empList.GroupBy(e => e.Loc).Select(g => new { City = g.Key, Count = g.Count() });
            foreach (var group in query9)
            {
                Console.WriteLine($"{group.City}: {group.Count}");
            }

            // 10. Display total number of employee based on city and title
            Console.WriteLine("\n10. Number of employees based on City and Title:");
            var query10 = empList.GroupBy(e => new { e.Loc, e.Job }).Select(g => new { g.Key.Loc, g.Key.Job, Count = g.Count() });
            foreach (var group in query10)
            {
                Console.WriteLine($"{group.Loc} - {group.Job}: {group.Count}");
            }

            // 11. Display total number of employee who is youngest in the list
            var youngestAge = empList.Max(e => e.BD);
            Console.WriteLine($"\n11. Number of youngest employees: {empList.Count(e => e.BD == youngestAge)}");

            Console.ReadLine();
        }
    }
}
