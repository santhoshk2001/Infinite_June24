using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    class Program3
    {
        static void Main()
        {
            Console.WriteLine(Largest(1, 2, 3));
            Console.WriteLine(Largest(1, 3, 2));
            Console.WriteLine(Largest(1, 1, 1));
            Console.WriteLine(Largest(1, 2, 2));

            Console.ReadLine();

        }

        static int Largest(int a, int b, int c)
        {
            if(a>=b && a>=c)
            {
                return a;
            }
            else if(b>=a && b>=c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
