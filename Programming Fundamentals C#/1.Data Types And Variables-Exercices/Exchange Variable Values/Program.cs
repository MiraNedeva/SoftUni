using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before: \na = {0} \nb = {1}",a,b);
          
            Console.WriteLine("After: \na = {0} \nb = {1} ",b,a);
        }
    }
}
