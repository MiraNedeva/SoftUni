using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Read an array of strings and find out if it’s symmetric. If it is, print “Yes”, otherwise print “No”.*/

namespace ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            var counter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == words[words.Length - i - 1])
                {
                    counter++;
                }
            }
            if (counter == words.Length)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
