using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
