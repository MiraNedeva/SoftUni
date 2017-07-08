using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var counter = 0;

            for (int i = numbers.Length - 2 ; i >= 0; i--)
            {
                if (numbers[i+1] > numbers[i])
                {
                    counter++;
                }
               
            }
            if (counter == numbers.Length - 1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
