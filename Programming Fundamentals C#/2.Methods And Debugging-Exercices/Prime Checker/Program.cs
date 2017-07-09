using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. */

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));

        }

        static bool IsPrime (long n)
        {
        
                int sqrtN = (int)Math.Sqrt(n);
                if (n <= 1)
                {
                    return false;
                }
                else if (n > 2)
                {
                    for (int divider = 2; divider <= sqrtN; divider++)
                    {
                        if (n % divider == 0)
                        {
                            return false;
                        }
                    }
                }
            return true;
            }

        }
    }

