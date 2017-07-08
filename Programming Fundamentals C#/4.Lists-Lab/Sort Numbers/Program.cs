using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<double> numbers = new List<double>();

            foreach (var item in input)
            {
                numbers.Add(double.Parse(item));
            }
            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
