using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You will receive a list of integers on the first input line (space-separated). Your task is to separate the list into two parts and 
perform the following operations: 
Assume you have the following initial list: 11, 22, 33, 45, 14, 22  
Split the list into 2 equal parts and stack the right half on top of the left half:   45, 14, 12 and  11, 22, 33
Place each digit of the upper list elements on either side of the lower list:
Exemple:     Input	                   Output
           11 22 33 45 14 12	       4 11 5 1 22 4 1 33 2
           82 77 12 84 92 11	       8 82 4 9 77 2 1 12 1
 */

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
    

