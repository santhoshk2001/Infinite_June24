using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Removechar("Python", 1));
            Console.WriteLine(Removechar("Python", 0));
            Console.WriteLine(Removechar("Python", 4));
            Console.ReadLine();
        }

        static string Removechar(string str, int pos)
        {
            if(pos>=0 && pos<str.Length)
            {
                return str.Remove(pos, 1);
            }
            else
            {
                return str;
            }
        }
    }
}
