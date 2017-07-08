using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =  Math.Abs(int.Parse((Console.ReadLine())));
            int result = GetMultipleOfEvensAndOdds(n);
            Console.WriteLine( Math.Abs(result));
        }

        private static int GetSumOfOddDigits(int n)
        {
            
             int sum = 0;
            while (n > 0 )
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }
        
    }
}
