using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurencesOfLargernumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var num = double.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > num)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
