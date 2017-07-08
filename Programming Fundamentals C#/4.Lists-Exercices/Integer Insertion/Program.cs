using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                var currentNumber = input[0];

                char digits = currentNumber.ToCharArray();

                var firstDigit = digits[0];

                numbers.Insert(currentNumber[firstDigit]);




                input = Console.ReadLine();
            }
        }
    }
}

