using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
