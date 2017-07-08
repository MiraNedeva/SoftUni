using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] len1 = Console.ReadLine().Split(' ').ToArray();  // 1 2 3 4 
            int[] array1 = new int[len1.Length]; // razmernost na masiv

            for (int i = 0; i < len1.Length; i++)
            {
                array1[i] = int.Parse(len1[i]); // присвояване на стойностите от стринговия масив в инт масива

            }

            string[] len2 = Console.ReadLine().Split(' ').ToArray();
            int[] array2 = new int[len2.Length];

            for (int i = 0; i < len2.Length; i++)
            {
                array2[i] = int.Parse(len2[i]); 

            }

            int max = Math.Max(len1.Length, len2.Length);
            int[] sumArrays = new int[max];

           
                for (int i = 0; i < max; i++)
                {

                    sumArrays[i] = array1[i % len1] + array2[i % len2];


                    Console.Write(sumArrays[i] + " ");
                }

            
            



        }
    }
}
