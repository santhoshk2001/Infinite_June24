using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double len, double bth)
        {
            Length = len;
            Breadth = bth;
        }

        public static Box Add(Box b1, Box b2)
        {
            double newLength = b1.Length + b2.Length;
            double newBreadth = b1.Breadth + b2.Breadth;
            return new Box(newLength, newBreadth);
        }

        public void Display()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }

    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Enter details for the first box:");
            Console.Write("Length: ");
            double length1 = double.Parse(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth1 = double.Parse(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);

            Console.WriteLine("Enter details for the second box:");
            Console.Write("Length: ");
            double length2 = double.Parse(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth2 = double.Parse(Console.ReadLine());

            Box box2 = new Box(length2, breadth2);

            // Add the two Box objects and store the result in a third Box object
            Box box3 = Box.Add(box1, box2);

            // Display the details of all three Box objects
            Console.WriteLine("\nDetails of the first box:");
            box1.Display();

            Console.WriteLine("\nDetails of the second box:");
            box2.Display();

            Console.WriteLine("\nDetails of the third box (result of addition):");
            box3.Display();

            Console.Read();
        }
    }
}
