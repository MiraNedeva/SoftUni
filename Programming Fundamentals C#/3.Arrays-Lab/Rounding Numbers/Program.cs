using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] arrayNumbers = Console.ReadLine().Split(' ').ToArray();
            double[] numbers = new double[arrayNumbers.Length];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                numbers[i] = double.Parse(arrayNumbers[i]);
                Math.Abs(numbers[i]);
            }
            int[] roundedNums = new int[numbers.Length];



            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Math.Abs(roundedNums[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => { roundedNums[i]}");
            }
        }
    }
}
 