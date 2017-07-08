using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayStr = Console.ReadLine().Split(' ').ToArray();
            int[] arrayNums = new int[arrayStr.Length];
            
          
            for (int i = 0; i < arrayNums.Length; i++)
            {
                arrayNums[i] = int.Parse(arrayStr[i]);
            }
           
            while (arrayNums.Length > 1)
            {
                
                int[] condensed = new int[arrayNums.Length - 1];

                for (int i = 0; i < condensed.Length ; i++)
                {
                    
                    condensed[i] = arrayNums[i] + arrayNums[i + 1];
                    //Console.Write(condensed[i] + " ");
                    
                }
                arrayNums = condensed;
                
               //Console.WriteLine(string.Join(" ", arrayNums));
            }

            foreach (var num in arrayNums)
            {
                Console.WriteLine(num);
            }
        }
    }
    }

