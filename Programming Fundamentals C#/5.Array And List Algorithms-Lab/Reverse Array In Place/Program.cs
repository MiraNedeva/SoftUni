using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Read a list of integers on the first line of the console. After that, reverse the array in-place (as in, don’t create a new collection to hold the result, reverse it using only the original array). After you are done, print the reversed array on the console.
Note: You are not allowed to iterate over the list backwards and just print it. */

namespace ReverseArrayInplace
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                var leftIndex = i;
                var rightIndex = numbers.Length - i - 1;

                var tempNumber = numbers[leftIndex];
                numbers[leftIndex] = numbers[rightIndex];
                numbers[rightIndex] = tempNumber;


            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
