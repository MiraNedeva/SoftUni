using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a method that takes as input two strings, and returns Boolean if they are exchangeable or not. Exchangeable are 
words where the characters in the first string can be replaced to get the second string. Example: "egg" and "add" are 
exchangeable, but "aabbccbb" and "nnooppzz" are not. (First 'b' corresponds to 'o', but then it also corresponds to 'z'). 
The two words may not have the same length, if such is the case they are exchangeable only if the longer one doesn't have 
more types of characters then the shorter one ("Clint" and "Eastwaat" are exchangeable because 'a' and 't' are already 
mapped as 'l' and 'n', but "Clint" and "Eastwood" aren't exchangeable because 'o' and 'd' are not contained in "Clint").*/

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
