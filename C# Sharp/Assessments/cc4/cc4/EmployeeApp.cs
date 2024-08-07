﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc4
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class EmployeeApp
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Display all employees");
                Console.WriteLine("2. Display employees whose location is not Mumbai");
                Console.WriteLine("3. Display employees whose title is AsstManager");
                Console.WriteLine("4. Display employees whose last name starts with 'S'");
                Console.WriteLine("5. Exit");
               
                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        DisplayAllEmployees(empList);
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        break;
                    case "2":
                        DisplayEmployeesNotInMumbai(empList);
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        break;
                    case "3":
                        DisplayAssistantManagers(empList);
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        break;
                    case "4":
                        DisplayEmployeesWithLastNameS(empList);
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void DisplayAllEmployees(List<Employee> empList)
        {
            Console.WriteLine("\na. Details of all employees:");
            foreach (var emp in empList)
            {
                DisplayEmployeeDetails(emp);
            }
        }

        static void DisplayEmployeesNotInMumbai(List<Employee> empList)
        {
            Console.WriteLine("\nb. Employees whose location is not Mumbai:");
            var employeesNotInMumbai = empList.Where(e => e.City != "Mumbai");
            foreach (var emp in employeesNotInMumbai)
            {
                DisplayEmployeeDetails(emp);
            }
        }

        static void DisplayAssistantManagers(List<Employee> empList)
        {
            Console.WriteLine("\nc. Employees whose title is AsstManager:");
            var assistantManagers = empList.Where(e => e.Title == "AsstManager");
            foreach (var emp in assistantManagers)
            {
                DisplayEmployeeDetails(emp);
            }
        }

        static void DisplayEmployeesWithLastNameS(List<Employee> empList)
        {
            Console.WriteLine("\nd. Employees whose last name starts with 'S':");
            var employeesWithLastNameS = empList.Where(e => e.LastName.StartsWith("S"));
            foreach (var emp in employeesWithLastNameS)
            {
                DisplayEmployeeDetails(emp);
            }
        }

        static void DisplayEmployeeDetails(Employee emp)
        {
            Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
        }
    }
}
