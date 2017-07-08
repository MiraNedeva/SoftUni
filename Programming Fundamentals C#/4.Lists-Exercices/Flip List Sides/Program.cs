using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var outputNumbers = new List<int>();


            if (numbers.Count % 2 != 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    outputNumbers.Add(numbers[i]);
                }

                var lastElement = outputNumbers[outputNumbers.Count - 1];
                var middleElement = outputNumbers[outputNumbers.Count / 2 + 1];
                var firstElement = outputNumbers[0];

                outputNumbers.RemoveAt(outputNumbers.Count - 1);
                outputNumbers.RemoveAt(outputNumbers.Count / 2 + 1);
                outputNumbers.RemoveAt(0);

                outputNumbers.Reverse();

                outputNumbers.Insert(0, firstElement);
                outputNumbers.Insert(outputNumbers.Count / 2, middleElement);
                outputNumbers.Add(lastElement);


            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    outputNumbers.Add(numbers[i]);
                }


                var lastEvenElement = outputNumbers[outputNumbers.Count - 1];
                var firstEvenElement = outputNumbers[0];

                outputNumbers.RemoveAt(outputNumbers.Count - 1);
                outputNumbers.RemoveAt(0);

                outputNumbers.Reverse();

                outputNumbers.Insert(0, firstEvenElement);
                outputNumbers.Add(lastEvenElement);
            }
            Console.WriteLine(string.Join(" ", outputNumbers));
        }
       
    }
    }

