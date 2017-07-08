using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var results = new List<int>();

            int counter = 0;

            for (int i = numbers.Count; i > 0; i--)
            {
                if (numbers[i-1] > 0)
                {
                    results.Add(numbers[i-1]);
                    counter++;
                }
                //  numbers.RemoveAll(x => x < 0);
            }
            if (results.Count == 0)
                {
                    Console.Write("empty");
                }
                else
                {
                    Console.Write(string.Join (" ", results));
                }
            
            
            
        }
    }
}
