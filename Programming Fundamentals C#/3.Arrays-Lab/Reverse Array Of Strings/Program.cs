using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayStr = Console.ReadLine().Split(' ').ToArray();
            string[] reversedStr = new string[arrayStr.Length];

            for (int i = 0; i < arrayStr.Length; i++)
            {
                reversedStr[arrayStr.Length - i - 1] = arrayStr[i];
            }
            for (int i = 0; i <arrayStr.Length; i++)
            {
                Console.Write(reversedStr[i] + " ");
            }
        }
    }
}
