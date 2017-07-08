using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;
            //int count = k;
            for (int i = 1; i < array.Length; i++)
            {
                long sum = 0;
                /*if (count == 0)
                {
                    break;
                }*/
                for (int j = i-1;  j >= 0; j--)
                {
                    if (j < i - k)
                    {
                        break;
                    }
                    sum += array[j];
                    // count--;
                }
                array[i] = sum;
            }
            Console.WriteLine(string.Join(" ",array));

        }
    }
}
