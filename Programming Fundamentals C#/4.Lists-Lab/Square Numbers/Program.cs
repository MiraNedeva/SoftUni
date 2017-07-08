using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Read a list of integers and extract all square numbers from it and print them in descending order. A square number is an integer
which is the square of any integer. For example, 1, 4, 9, 16 are square numbers.*/

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            List<int> squareNumbers = new List<int>();

            foreach (var item in numbers)
            {
                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    squareNumbers.Add(item);
                }
               
            }

            squareNumbers.Sort((a, b) => b.CompareTo(a));
               
               
        
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
