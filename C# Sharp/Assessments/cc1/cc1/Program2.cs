using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    class Program2
    {
        static void Main()
        {
            Console.WriteLine(Exchange("abcd"));
            Console.WriteLine(Exchange("a"));
            Console.WriteLine(Exchange("xy"));

            Console.ReadLine();
        }

        static string Exchange(string str)
        {
            if(str.Length<=1)
            {
                return str;
            }

            /*char fc = str[0];
            char lc = str[1];
            string m = str.Substring(1, str.Length - 2);
            return lc + m + fc;*/

            char[] ca = str.ToCharArray();
            char temp = ca[0];
            ca[0] = ca[ca.Length - 1];
            ca[ca.Length - 1] = temp;

            return new string(ca);
        }
    }
}
