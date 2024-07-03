using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box Add(Box b1, Box b2)
        {
            double newLength = b1.Length + b2.Length;
            double newBreadth = b1.Breadth + b2.Breadth;
            return new Box(newLength, newBreadth);
        }

        public void Display()
        {
            Console.WriteLine("Length: " + Length);
            Console.WriteLine("Breadth: " + Breadth);
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            // Taking user input for the first Box object
            Console.Write("Enter the length of the first box: ");
            double l1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the breadth of the first box: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            // Taking user input for the second Box object
            Console.Write("Enter the length of the second box: ");
            double l2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the breadth of the second box: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            // Creating two Box objects with user input
            Box box1 = new Box(l1, b1);
            Box box2 = new Box(l2, b2);

            // Adding the two Box objects and storing the result in a third Box object
            Box box3 = Box.Add(box1, box2);

            // Displaying the details of the third Box object
            Console.WriteLine("\nDetails of the third Box object:");
            box3.Display();

            Console.Read();
        }
    }
}
