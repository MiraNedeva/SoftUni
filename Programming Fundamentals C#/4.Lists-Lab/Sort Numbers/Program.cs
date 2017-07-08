using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
/* Read a list of decimal numbers and sort them in increasing order. Print the output as shown in the examples below.
Input	          Output
8 2 7 3	       2 <= 3 <= 7 <= 8
2 4 -9	      -9 <= 2 <= 4         */

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<double> numbers = new List<double>();

            foreach (var item in input)
            {
                numbers.Add(double.Parse(item));
            }
            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
