using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program3
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "Santhosh", EmpCity = "Bangalore", EmpSalary = 50000 },
            new Employee { EmpId = 2, EmpName = "Vinay", EmpCity = "Mumbai", EmpSalary = 40000 },
            new Employee { EmpId = 3, EmpName = "Bharath", EmpCity = "Bangalore", EmpSalary = 55000 },
            new Employee { EmpId = 4, EmpName = "Punith", EmpCity = "Chennai", EmpSalary = 47000 },
            new Employee { EmpId = 5, EmpName = "Srinivas", EmpCity = "Bangalore", EmpSalary = 45000 }
        };

            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Display all employees data");
                Console.WriteLine("2. Display all employees data whose salary is greater than 45000");
                Console.WriteLine("3. Display all employees data who belong to Bangalore Region");
                Console.WriteLine("4. Display all employees data by their names is Ascending order");
                Console.WriteLine("5. Exit");
                Console.WriteLine("--------------------------------------------------------------------------------");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("\nAll Employees Data:");
                        DisplayAllEmployees(employees);
                        break;
                    case "2":
                        Console.WriteLine("\nEnter the minimum salary:");
                        if (double.TryParse(Console.ReadLine(), out double salary))
                        {
                            Console.WriteLine($"\nEmployees with Salary Greater than {salary}:");
                            DisplayEmployeesBySalary(employees, salary);
                        }
                        else
                        {
                            Console.WriteLine("Invalid salary input.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nEnter the city:");
                        string city = Console.ReadLine();
                        Console.WriteLine($"\nEmployees from {city}:");
                        DisplayEmployeesByCity(employees, city);
                        break;
                    case "4":
                        Console.WriteLine("\nEmployees Sorted by Name:");
                        DisplayEmployeesSortedByName(employees);
                        break;
                    case "5":
                        return; 
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }
        }

        static void DisplayAllEmployees(List<Employee> employees)
        {
            employees.ForEach(emp => Console.WriteLine(emp));
        }

        static void DisplayEmployeesBySalary(List<Employee> employees, double salaryThreshold)
        {
            var filteredEmployees = employees
                .Where(emp => emp.EmpSalary > salaryThreshold)
                .ToList();

            filteredEmployees.ForEach(emp => Console.WriteLine(emp));
        }

        static void DisplayEmployeesByCity(List<Employee> employees, string city)
        {
            var filteredEmployees = employees
                .Where(emp => emp.EmpCity.Equals(city, StringComparison.OrdinalIgnoreCase))
                .ToList();

            filteredEmployees.ForEach(emp => Console.WriteLine(emp));
        }

        static void DisplayEmployeesSortedByName(List<Employee> employees)
        {
            var sortedEmployees = employees
                .OrderBy(emp => emp.EmpName)
                .ToList();

            sortedEmployees.ForEach(emp => Console.WriteLine(emp));
        }
    }

    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }

        public override string ToString()
        {
            return $"ID: {EmpId}, Name: {EmpName}, City: {EmpCity}, Salary: {EmpSalary}";
        }
    }
}
