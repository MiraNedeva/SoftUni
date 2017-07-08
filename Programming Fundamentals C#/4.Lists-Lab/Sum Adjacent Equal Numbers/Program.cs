using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well 
	Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available).*/

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           List <double> input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                double firstNumber = input[i];
                double secondNumber = input[i + 1];

                if (firstNumber == secondNumber)
                {
                    input[i] = 2 * input[i];
                    input.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ",input));

        }
    }
}
