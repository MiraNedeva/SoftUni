using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a string from the console, reverses it and prints the result back at the console. */

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = new string(input.ToCharArray().Reverse().ToArray());

            Console.WriteLine(output);
            
        }
    }
}
