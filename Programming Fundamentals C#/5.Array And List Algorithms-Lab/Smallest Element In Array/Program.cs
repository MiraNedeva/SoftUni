using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Read a list of integers on the first line of the console. After that, find the smallest element in the array and print it on the console.*/

namespace SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var smallestInt = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (smallestInt > numbers[i])
                {
                    smallestInt = numbers[i];
                }
            }
            Console.WriteLine(smallestInt);
        }
    }
}
