using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/* Write a program that takes a base-10 number (0 to 1050) and converts it to a base-N number, where 2 <= N <= 10.
The input consists of 1 line containing two numbers separated by a single space. The first number is the base N to which you
have to convert. The second one is the base 10 number to be converted. Do not use any built in converting functionality, 
try to write your own algorithm.
Hints:
About the algorithm (from base-10 to base-2) you can read this article.
The algorithm for converting from base-10 to base-N is similar: instead of “ % 2”, use “% N”. */

namespace ConvertFromBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var basedNnumber = int.Parse(input[0]);
            var based10Number = BigInteger.Parse(input[1]);

            var result = ConvertFromBase10ToBaseN( based10Number, basedNnumber);

            Console.WriteLine(result);
        }

        private static object ConvertFromBase10ToBaseN(BigInteger based10Number, int basedNnumber)
        {
            var result = string.Empty;
            

            while (based10Number != 0)
            {
                var remaider = based10Number % basedNnumber;
                result = remaider + result;
                based10Number = based10Number/ basedNnumber;
            }

            return result;
        }
    }
}
