using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputWords = Console.ReadLine().ToCharArray();
            var counts = new Dictionary<char, int>();

            foreach (var character in inputWords)
            {
                if (! counts.ContainsKey(character))
                {
                    counts[character] = 0;
                }
                counts[character]++;
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
    }
}
