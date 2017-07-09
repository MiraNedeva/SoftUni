using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

/* Calculate and print n! (n factorial) for very big integer n (e.g. 1000).*/

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = n; i > 1; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);

        }
    }
}
