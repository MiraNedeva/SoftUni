using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayNumbers = Console.ReadLine().Split(' ').ToArray();
            int[] array = new int[arrayNumbers.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(arrayNumbers[i]);
            }                     
            bool foundSum = false;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    for (int k  = 0; k  < array.Length; k++)
                    {
                        if (array[i] + array[j] == array[k])
                        {
                            Console.WriteLine($"{array[i]} + {array[j]} == {array[k]}");
                            foundSum = true;
                            break;
                        }
                    }
                }
            }
            if (!foundSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
