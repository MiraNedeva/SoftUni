using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
