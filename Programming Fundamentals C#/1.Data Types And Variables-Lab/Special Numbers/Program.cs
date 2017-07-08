using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum = 0;
            for (int num = 1; num <= n; num++)
            {

                sum1 = num % 10;
                sum2 = num / 10;
                sum = sum1 + sum2;
                if ((sum == 5) || (sum ==7) || (sum == 11))
                {
                    Console.WriteLine("{0} -> True", num);
                }
                else
                {
                    Console.WriteLine("{0} -> False",num);
                }
            }
            //Console.WriteLine(sum1);
            //Console.WriteLine(sum2);
           // Console.WriteLine(sum);
            
        }
    }
}
