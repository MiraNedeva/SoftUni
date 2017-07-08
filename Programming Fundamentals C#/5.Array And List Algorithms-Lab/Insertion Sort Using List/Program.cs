using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Read a list of integers on the first line of the console.After that, sort the array, using the Insertion Sort algorithm, 
but instead of doing it in-place, add the result one by one to a list. */

namespace InsertionSortUsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(numbers); // List -> numbers.Sort();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
