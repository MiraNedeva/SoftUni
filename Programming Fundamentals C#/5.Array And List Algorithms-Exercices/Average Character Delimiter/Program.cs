using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You will receive an array of strings as input. Your task is to find the average character within every string in the array. As in, 
take every character’s ASCII code, sum it and divide the result by the sum of the count of all the letters in the array.
Example:
a b ab abc abc  a, b, a, b a, b, c, a, b, c  sum: 978  Divide it by 10: 97.8  97
After you find the average sum, convert it to its ASCII character representation, convert it to uppercase and print the original array,
delimited by that character.*/

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
