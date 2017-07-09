using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are given a list of words in one line. Randomize their order and print each word at a separate line.*/

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomPosition = random.Next(0, words.Length);
                var tempWord = words[randomPosition];
                words[randomPosition] = currentWord;
                words[i] = tempWord;
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
