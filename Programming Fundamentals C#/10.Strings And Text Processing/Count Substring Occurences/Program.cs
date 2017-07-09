using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program to find how many times a given string appears in a given text as substring. The text is given at the 
first input line. The search string is given at the second input line. The output is an integer number. Please ignore the 
character casing. Overlapping between occurrences is allowed.*/

namespace DemoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            var counter = 0;
            var index = 0;

            while (true)
            {
                var found = text.IndexOf(pattern, index);

                if (found >= 0)
                {
                    counter++;
                    index = found + 1;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine(counter);

        }
    }
}
