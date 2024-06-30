using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public float Salary { get; set; }

        public Employee(int empid, string empname, float salary)
        {
            Empid = empid;
            Empname = empname;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID: {Empid}, Name: {Empname}, Salary: {Salary}");
        }
    }

    public class ParttimeEmployee : Employee
    {
        public float Wages { get; set; }

        // Constructor to initialize the part-time emp details and call the base class constructor
        public ParttimeEmployee(int empid, string empname, float salary, float wages)
            : base(empid, empname, salary)
        {
            Wages = wages;
        }

        // Method to display part-time emp details including wages
        public void DisplayParttimeEmployee()
        {
            Display(); 
            Console.WriteLine($"Wages: {Wages}");
        }
    }

    public class Program3
    {
        public static void Main()
        {
            Console.WriteLine("Enter details for the part-time employee:");

            Console.Write("Employee ID: ");
            int empid = int.Parse(Console.ReadLine());

            Console.Write("Employee Name: ");
            string empname = Console.ReadLine();

            Console.Write("Salary: ");
            float salary = float.Parse(Console.ReadLine());

            Console.Write("Wages: ");
            float wages = float.Parse(Console.ReadLine());

            // Creating instance of ParttimeEmp
            ParttimeEmployee pte = new ParttimeEmployee(empid, empname, salary, wages);

            // Displaying part-time emp details
            Console.WriteLine("\nPart-time Employee Details:");
            pte.DisplayParttimeEmployee();

            Console.Read();
        }
    }
}
