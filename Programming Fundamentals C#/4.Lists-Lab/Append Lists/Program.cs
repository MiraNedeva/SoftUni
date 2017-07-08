using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program to append several lists of numbers.
	Lists are separated by ‘|’.
	Values are separated by spaces (‘ ’, one or several)
	Order the lists from the last to the first, and their values from left to right.*/

namespace AppendLists
{
    class Program
    {
         static void Main(string[] args)
            {
            var numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();


            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    numbers[i] = numbers[i] + numbers[i - 1];
                    numbers.Remove(numbers[i - 1]);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
