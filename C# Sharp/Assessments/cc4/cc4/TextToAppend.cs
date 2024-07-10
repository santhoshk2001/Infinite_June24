using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc4
{
    class TextToAppend
    {
        static void Main()
        {
            string filePath = "C:\\Users\\santhoshke\\Infinite_June24\\C# Sharp\\Assessments\\cc4\\MyExample.txt";
            Console.Write("Enter the text to append: ");
            string textToAppend = Console.ReadLine();


            AppendTextToFile(filePath, textToAppend);
            Console.WriteLine("Text appended to the file.");

            Console.Read();
        }

        static void AppendTextToFile(string filePath, string textToAppend)
        {
            try
            {
                // Append text to the file, if the file doesn't exist, it will create a new one
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(textToAppend);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
