using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var k = numbers.Count / 4;

            var firstPartRow = numbers
                .Take(k)
                .Reverse()
                .ToList();

            var secondPartRow = numbers
                .Skip(2 * k + k)
                .Take(k)
                .Reverse()
                .ToList();

                   //Console.WriteLine(string.Join(", ", firstPartRow));
                  //Console.WriteLine(string.Join(", ", secondPartRow));

            var upperRow = firstPartRow.Concat(secondPartRow).ToList();
                //Console.WriteLine(string.Join(", ", upperRow));

            var lowerRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToList();

              //Console.WriteLine(string.Join(", ", lowerRow));

            var sumNumbers = new int[upperRow.Count];

            for (int i = 0; i < upperRow.Count; i++)
            {
               sumNumbers[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ",sumNumbers));
            }
        
        }
    }

