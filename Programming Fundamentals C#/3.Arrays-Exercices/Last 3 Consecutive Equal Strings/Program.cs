using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            var counter = 1;
            
            for (int i = words.Length - 1; i > 0; i--)
            {
                if (words[i] == words[i-1])
                {
                    counter++;
                    if (counter == 3)
                    {
                        Console.WriteLine("{0} {0} {0}", words[i]);
                        break;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
           
            
        }
    }
}
