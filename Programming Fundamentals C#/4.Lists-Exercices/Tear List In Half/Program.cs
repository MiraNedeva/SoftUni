using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondPartList = new List<int>();
            var firstPartList = new List<int>();
            var length = numbers.Count + (numbers.Count / 2);
            var finalList = new List<int>(length);

            var middle = numbers.Count / 2;
                  
            for (int i = 0; i < middle; i++)
            {
                firstPartList.Add(numbers[i]);
            }

            for (int i = middle; i < numbers.Count; i++)
            {
                secondPartList.Add(numbers[i]);
            }
            for (int i = 0; i < firstPartList.Count; i++)
            {
                finalList.Add(secondPartList[i] / 10);
                finalList.Add(firstPartList[i]);
                finalList.Add(secondPartList[i] % 10);
            }
            Console.WriteLine(string.Join(" ",finalList));

            }
          }
          }
    

