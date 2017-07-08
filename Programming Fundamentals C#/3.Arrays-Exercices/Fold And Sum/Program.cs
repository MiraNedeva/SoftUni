using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = new int[input.Length];

             for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int k = input.Length / 4;

            int[] firstArray = new int[2 * k];
            int[] secondArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                firstArray[i] = numbers[k - i - 1];
            }

            for (int i = 0; i < k; i++)
            {
                firstArray[k + i] = numbers[4*k - 1 - i];
            }

            for (int i = 0; i < 2*k; i++)
            {
                secondArray[i] = numbers[k+ i];

            }
            for (int i = 0; i < 2*k; i++)
            {
                Console.Write(firstArray[i] + secondArray[i] + " ");
            }
        }
    }
}
