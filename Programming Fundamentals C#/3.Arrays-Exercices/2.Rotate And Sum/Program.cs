using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int[] numbers = parsedNumbers(input);
            long[] sum = new long[input.Length];

            int rotations = int.Parse(Console.ReadLine());

            MakeRotations(numbers, sum, rotations);

            Console.WriteLine(string.Join(" ", sum));

        } 

        static  int[] parsedNumbers(string[]input)
        {
            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            return numbers;
        }


        static void MakeRotations(int[] numbers, long[] sum, int rotations)
        {
            
            for (int rotation = 0; rotation < rotations; rotation++)
            {
                int lastNumber = numbers[numbers.Length - 1];
                for (int element = numbers.Length - 1; element > 0; element--)
                {
                    numbers[element] = numbers[element - 1];
                }
                numbers[0] = lastNumber;

                for (int i = 0; i < numbers.Length; i++)
                {
                    sum[i] += numbers[i];
                }
               // Console.WriteLine(string.Join(" , ", numbers));
            }
        }
    }
}
