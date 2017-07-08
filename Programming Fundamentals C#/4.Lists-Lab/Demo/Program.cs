using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var results = new List<int>();

            foreach (var item in numbers)
            {
                if (item > 0)
                {
                    results.Add(item);
                }
            }
            foreach (var item in numbers)
            {
                if (item < 0)
                {
                    results.Remove(item);
                }
            }
            results.Reverse();
            if (results.Any())
            {
                Console.Write(string.Join(" ", results));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
