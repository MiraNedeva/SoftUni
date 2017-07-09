using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a method that prints the digits of a given decimal number in a reversed order.*/

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

             string  result = NumbersInReversedOrder(number);
            //Console.WriteLine(result);
        }


        static string NumbersInReversedOrder(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            return (number);
        }
    }
}
