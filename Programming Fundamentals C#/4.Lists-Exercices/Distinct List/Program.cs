using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
/* You will be given a list of integers on the first line of the input (space-separated). Remove all repeating elements from the list.*/

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
