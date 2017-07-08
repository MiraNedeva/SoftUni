using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            int sum = 0;
            var average = 0;
            var count = 0;
            

            foreach (var item in words)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    sum += item[i];
                    count++;
                }       
                }
            average = sum / count;
            
            if (average >= 97  && average <= 122)
            {
               average-= 32;
            }
            var letter = (char)average;

            for (int i = 0; i < words.Length-1; i++)
            {
                Console.Write(words[i] + letter);
            }

            Console.WriteLine(words[words.Length-1]);

            //Console.WriteLine(sum);
            //Console.WriteLine(average);

        }
    }
}
