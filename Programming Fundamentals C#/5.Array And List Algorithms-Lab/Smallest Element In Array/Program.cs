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
            var smallestInt = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (smallestInt > numbers[i])
                {
                    smallestInt = numbers[i];
                }
            }
            Console.WriteLine(smallestInt);
        }
    }
}
