using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Read a list of integers on the first line of the console. On the next line, you will receive an integer N. After that, 
find and print the largest N elements the array, sorted in descending order.*/

namespace LargestNElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var n = int.Parse(Console.ReadLine());

             numbers.Sort();
             numbers.Reverse();

            var result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                result.Add(numbers[i]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
