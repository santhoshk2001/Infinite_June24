using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    using System;

    public class Student
    {
        private int rollNo;
        private string name;
        private string studentClass;
        private string semester;
        private string branch;
        private int[] marks = new int[5];

        public Student(int rollNo, string name, string studentClass, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.studentClass = studentClass;
            this.semester = semester;
            this.branch = branch;
        }

        public void GetMarks()
        {
            Console.WriteLine($"Enter marks for {name}:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            double averageMarks = CalculateAverageMarks();

            Console.WriteLine("\nResult Details:");
            if (HasFailedInAnySubject())
            {
                Console.WriteLine("Result: Failed (Marks of at least one subject is less than 35)");
            }
            else if (averageMarks >= 50)
            {
                Console.WriteLine($"Result: Passed (Average Marks: {averageMarks})");
            }
            else
            {
                Console.WriteLine($"Result: Failed (Average Marks: {averageMarks}, but all subjects have > 35 marks)");
            }
        }

        private double CalculateAverageMarks()
        {
            double sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return sum / 5;
        }

        private bool HasFailedInAnySubject()
        {
            foreach (int mark in marks)
            {
                if (mark < 35)
                    return true;
            }
            return false;
        }

        public void DisplayData()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {studentClass}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
            }
        }

        public static void Main()
        {
            Student student1 = new Student(1, "Santhosh K", "B.E", "2nd", "CSE");

            student1.GetMarks();

            student1.DisplayData();

            student1.DisplayResult();

            Console.ReadLine();
        }
    }

}
