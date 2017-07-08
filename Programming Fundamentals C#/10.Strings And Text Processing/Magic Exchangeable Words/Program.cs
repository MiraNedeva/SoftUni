using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string firstWord = words[0];
            string secondWord = words[1];

            Dictionary<char, char> map = new Dictionary<char, char>();


            int minLen = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < minLen; i++)
            {
                if (!map.ContainsKey(firstWord[i]))
                {
                    map.Add(firstWord[i], secondWord[i]);
                }
                else
                {
                    if (map[firstWord[i]] != secondWord[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }
            string substr = string.Empty;

            if (firstWord.Length > secondWord.Length)
            {
                substr = firstWord.Substring(minLen);
            }
            else
            {
                substr = secondWord.Substring(minLen);
            }
            if (substr.All(ch => map.Values.Contains(ch) || map.Keys.Contains(ch)))
            {
                Console.WriteLine("true");
                return;
            }
            Console.WriteLine("false");
            
        }
    }
}
