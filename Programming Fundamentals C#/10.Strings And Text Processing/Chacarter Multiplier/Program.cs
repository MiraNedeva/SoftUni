using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a method that takes two strings as arguments and returns the sum of their character codes multiplied 
(multiply str1.charAt (0) with str2.charAt (0) and add to the total sum). Then continue with the next two characters. 
If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.*/

namespace ChacarterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string first = input[0];
            string second = input[1];

            long sum = CalculateSum(first, second);

            Console.WriteLine(sum);
        }

        private static long CalculateSum(string first, string second)
        {
            char[] firstArr = first.ToCharArray();
            char[] secondArr = second.ToCharArray();

            int sum = 0;

            int minLen = Math.Min(firstArr.Length, secondArr.Length);
            int maxLen = Math.Max(firstArr.Length, secondArr.Length);

            for (int i = 0; i < minLen; i++)
            {
                sum += firstArr[i] * secondArr[i];
            }
            if (maxLen == firstArr.Length)
            {
                for (int i = minLen; i < maxLen; i++)
                {
                    sum += firstArr[i];
                }

            }
            else
            {
                for (int i = minLen; i < maxLen; i++)
                {
                    sum += secondArr[i];
                }
            }
            

            return sum;
        }
    }
}
