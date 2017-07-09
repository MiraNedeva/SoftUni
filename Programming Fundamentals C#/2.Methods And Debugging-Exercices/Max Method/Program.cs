using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a method GetMax(int a, int b), that returns maximal of two numbers. Write a program that reads three numbers from
the console and prints the biggest of them. Use the GetMax(…) method you just created.*/

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int bigger = GetMax(n1, n2);
            if (bigger > n3)
            {
                Console.WriteLine(bigger);
            }
            else
            {
                Console.WriteLine(n3);
            }

        }

        static int GetMax (int a , int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
    }
}
