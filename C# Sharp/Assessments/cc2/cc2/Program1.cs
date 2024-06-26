using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc2
{
    abstract class Student
    {
        public string Name { get; set; }
        public string StudentId { get; set; }
        public double Grade { get; set; }

        public Student(string name, string studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }

        public abstract bool IsPassed(double grade);
    }

    class UnderGraduate : Student
    {
        public UnderGraduate(string name, string studentId, double grade)
            : base(name, studentId, grade)
        {
        }

        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public Graduate(string name, string studentId, double grade)
            : base(name, studentId, grade)
        {
        }

        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Undergraduate 2. Graduate 3. Exit");
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Manage_Student("UnderGraduate");
                        break;

                    case "2":
                        Manage_Student("Graduate");
                        break;

                    case "3":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void Manage_Student(string studentType)
        {
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the student's ID: ");
            string studentId = Console.ReadLine();

            Console.Write("Enter the student's grade: ");
            double grade;
            while (!double.TryParse(Console.ReadLine(), out grade))
            {
                Console.Write("Invalid input. Please enter a valid grade: ");
            }

            Student student = null;

            if (studentType == "UnderGraduate")
            {
                student = new UnderGraduate(name, studentId, grade);
            }
            else if (studentType == "Graduate")
            {
                student = new Graduate(name, studentId, grade);
            }

            Console.WriteLine($"{student.Name} has a grade of {student.Grade}. Passed: {student.IsPassed(student.Grade)}");
        }
    }

}
