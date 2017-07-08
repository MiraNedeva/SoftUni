using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayStr = Console.ReadLine().Split(' ').ToArray();
            int[] arrayNums = new int[arrayStr.Length];
            //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arrayNums.Length; i++)
            {
                arrayNums[i] = int.Parse(arrayStr[i]);
            }
            int middle = arrayNums.Length / 2;
            if (arrayNums.Length == 1)
            {
                Console.WriteLine(arrayNums[0]);
            }
            else if (arrayNums.Length % 2 == 0)
            {

                Console.WriteLine($"{arrayNums[middle - 1]} {arrayNums[middle]}");
            }
            else if (arrayNums.Length % 2 == 1)
            {
                Console.WriteLine($"{arrayNums[middle - 1]} {arrayNums[middle]} {arrayNums[middle + 1]}");
            }
        }
    }
}
