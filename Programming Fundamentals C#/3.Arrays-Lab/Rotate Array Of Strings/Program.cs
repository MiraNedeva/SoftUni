using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initialArray = Console.ReadLine().Split(' ').ToArray();
            string[] reversedArray = new string[initialArray.Length];

            for (int i = 0; i < initialArray.Length - 1 ; i++)
            {
                reversedArray[0] = initialArray[initialArray.Length - 1];
                reversedArray[i + 1] = initialArray[i];
               
            }

            //print reversed array

            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }
        }
    }
}
