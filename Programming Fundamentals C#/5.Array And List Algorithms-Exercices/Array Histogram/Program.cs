using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You will be given a string array on the console (single line, space-separated). Your task is to make statistics about the elements of the array. Find out how many times each word occurs in the array. After which, sort the result by the count of occurrences in descending order and print statistics about every word in the following format:
{word} -> {count} times ({percentage:F2}%)  */

namespace ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<string> words = new List<string>();
            List<int> occurrences = new List<int>();
            

            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];
                if (! words.Contains(currentWord))
                {
                    words.Add(currentWord);
                    occurrences.Add(1);
                    
                }
                else
                {
                    int wordIndex = words.IndexOf(currentWord);
                    occurrences[wordIndex]++;
                }
            }
           
            occurrences.OrderByDescending(x => x);

            for (int i = 0; i < words.Count; i++)
            {
                double percentage = (occurrences[i] * 100.0) / input.Length;
                Console.WriteLine("{0} -> {1} times ({2:F2}%)",words[i],occurrences[i], percentage);
            }
          
        }
    }
}
