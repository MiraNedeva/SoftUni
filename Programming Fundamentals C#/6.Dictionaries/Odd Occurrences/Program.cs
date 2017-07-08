using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that extracts from a given sequence of words all elements that present in it odd number of times (case-insensitive).
•	Words are given in a single line, space separated.
•	Print the result elements in lowercase, in their order of appearance.*/

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputWords = Console.ReadLine().ToLower().Split(new char[] { },StringSplitOptions.RemoveEmptyEntries).ToArray();
            var counts = new Dictionary<string, int>();

            foreach (var word in inputWords)
            {
                if (! counts.ContainsKey(word))
                {
                    counts[word] = 0;
                }
                
                    counts[word]++;
                
            }
            var oddOccurenrences = new List<string>();
            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    oddOccurenrences.Add(item.Key);
                    
                }
            }
            Console.Write(string.Join(", ", oddOccurenrences));
        }
    }
}
