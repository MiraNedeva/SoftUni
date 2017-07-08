using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var numbers = input.Select(int.Parse).ToList();

            var sortedNumbers = numbers.OrderByDescending(x => x);
            var largest3Numbers = sortedNumbers.Take(3);

            Console.WriteLine(string.Join(" ", largest3Numbers));

        }
    }
}
