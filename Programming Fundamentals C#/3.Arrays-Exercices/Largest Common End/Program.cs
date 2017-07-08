using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ').ToArray();
            string[] second = Console.ReadLine().Split(' ').ToArray();

            int maxCountLeft = ScanFromLeft(first, second);
            int maxCountRight = ScanFromRight(first, second);

            if (maxCountLeft == maxCountRight)
            {
                Console.WriteLine(0);
            }
            else if (maxCountLeft > maxCountRight)
            {
                Console.WriteLine(maxCountLeft);
            }
            else
            {
                Console.WriteLine(maxCountRight);
            }

            
        }

        ///////////////////// Method for scan from left ////////////////

        static int ScanFromLeft (string[]first, string[] second)
        {
            int count = 0;
            int maxCount = 0;

            int minLength = Math.Min(first.Length, second.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (first[i] == second[i])
                {
                    count++;
                }
                else
                {
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }

         
            return maxCount;
        }

         //////////// method for scan from rigth ///////////

        static int ScanFromRight(string[] first, string[] second)
        {
            int count = 0;
            int maxCount = 0;

            if (first.Length > second.Length)
            {
                int longArrayIndex = first.Length - 1;

                for (int i = second.Length - 1; i >= 0; i--)
                {
                    if (first[longArrayIndex] == second[i])
                    {
                        count++;
                    }
                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }
                    longArrayIndex--;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                }

            }
           

            
            return maxCount;
        }
    }
}
