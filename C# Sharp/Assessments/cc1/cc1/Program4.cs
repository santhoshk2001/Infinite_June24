using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    class Program4
    {
        static void Main()
        {
            int num = 5;
            Tables(num);
            Console.ReadLine();
        }

        static void Tables(int num)
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine($"{num}*{i}={num*i}");
            }
        }
    }
}
