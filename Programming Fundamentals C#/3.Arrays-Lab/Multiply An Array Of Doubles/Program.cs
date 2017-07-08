using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var p = double.Parse(Console.ReadLine());
            var result = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = numbers[i] * p;
                Console.Write("{0} ",result[i]);
                
            }

        }
    }
}
