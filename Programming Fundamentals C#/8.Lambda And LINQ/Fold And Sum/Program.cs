using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Read an array of 4*k integers, fold it like shown below, and print the sum of the upper and lower rows (2*k integers):
//Hints
/*Use a LINQ expression:
•	Row 1, left part: take the first k numbers and reverse.
•	Row 1, right part: reverse and take the first k numbers.
•	Concatenate the left and the right part of row 1.
•	Row 2: skip the first k numbers and take the next 2*k numbers.
•	Sum the arrays row1 and row2: var sum = row1.Select((x, index) => x + row2[index]).*/



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

