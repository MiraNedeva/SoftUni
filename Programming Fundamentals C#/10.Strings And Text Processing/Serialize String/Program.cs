using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



