using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are given two lines - each can be a really big number (0 to 1050). You must display the sum of these numbers.
Note: do not use the BigInteger or BigDecimal classes for solving this problem. */

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine().TrimStart(new char[] { '0'});
            var secondNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            
            Console.WriteLine("{0}", firstNumber + secondNumber);
        }
    }
}
