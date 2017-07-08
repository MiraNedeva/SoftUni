using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num1 = 0;
            bool special = false;

            for (int i = 1; i <= n; i++)
            {
                num1 = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{num1} -> {special}");
                sum = 0;
                i = num1;
            }

        }
    }
}
