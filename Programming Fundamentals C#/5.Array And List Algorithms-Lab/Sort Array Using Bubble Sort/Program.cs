using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Read a list of integers on the first line of the console. After that, sort the array, using the Bubble Sort algorithm.*/

namespace SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool swapped = false; // priemame che masiva veche e sortiran

            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    var currentElement = numbers[i];
                    var nextElement = numbers[i + 1];
                    if (currentElement > nextElement)
                    {
                       
                        numbers[i + 1] = currentElement;
                        numbers[i] = nextElement;
                        swapped = true;
                    }
                }
            } while (swapped);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
