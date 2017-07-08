using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var smallestNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                if (currentNumber < smallestNumber)
                {
                    smallestNumber = numbers[i];
                }
               
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
