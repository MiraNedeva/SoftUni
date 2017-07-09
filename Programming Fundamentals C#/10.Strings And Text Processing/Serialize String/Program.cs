using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You have been tasked to serialize a string. The serialization is done in a special way, in which a character from that 
string is saved with the indexes at which it is found.
The input will consist of a single input line, containing a single string, which may consist of ANY ASCII character. 
Your task is to serialize the string in the following way: {char}:{index1}/{index2}/{index3}
The char will be the character, and the indexes, will be the indexes it is found at in the string.
Note: This problem is a string problem, and should ONLY use strings in its solution. */

namespace SerializeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] letter = word.ToCharArray();
            var dict = new Dictionary<char, List<int>>();

            for (int i = 0; i < letter.Length; i++)
            {
                if (!dict.ContainsKey(letter[i]))
                {
                    dict[letter[i]] = new List<int>();
                }
                dict[letter[i]].Add(i);
            }
            foreach (var item in dict)
            {
               /*string str = item.Value;
                 char[] occurences = str.Trim().ToCharArray();
                 Console.Write("{0}: {1}",item.Key, string.Join("/ ",occurences));
                 Console.WriteLine();
                 char letters = item.Key;*/
                Console.WriteLine("{0}:{1}",item.Key, string.Join("/",item.Value));
            }
           
            
        }
    }
}



