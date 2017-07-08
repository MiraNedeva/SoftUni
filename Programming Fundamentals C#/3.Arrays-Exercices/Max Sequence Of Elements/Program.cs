using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = 1;
            int start = 0;
            int bestLen = 0;
            int bestStart = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[start] == array[i])
                {
                    len++;

                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
                else
                    {
                        len = 1;
                        start = i;
                    }
               

            }
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(array[bestStart]);
            }

        }
    }
}