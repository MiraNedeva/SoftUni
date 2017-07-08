using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (! result.Contains(numbers[i]))
                {
                    result.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
