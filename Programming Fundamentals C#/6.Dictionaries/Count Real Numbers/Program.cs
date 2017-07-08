using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Read a list of real numbers and print them in ascending order along with their number of occurrences.
Hints:
•	Use SortedDictionary<double, int> named counts.
•	Pass through each input number num and increase counts[num] (when num exists in the dictionary) or assign counts[num] = 1 (when num does not exist in the dictionary).
•	Pass through all numbers num in the dictionary (counts.Keys) and print the number num and its count of occurrences counts[num].*/ 

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var counts = new SortedDictionary<double, int>();

            foreach (var num in inputNumbers)
            {
                if (! counts.ContainsKey(num))
                {
                    counts.Add(num, 1);
                }
                else
                {
                    counts[num]++;
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
