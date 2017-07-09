using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a program, which receives sentences of words, and capitalizes the words in them. 
The sentences will follow a correct grammatical order. You must extract each word from the sentences, and you must capitalize it.
The capitalization of a word, is the process of making the first letter from it – Capital, and every other – lowercase.
You should read input lines, until you receive the command “end”.
You might receive SEVERAL sentences on 1 input line.
After you’ve read a sentence, you extract the words, capitalize them, and print them, separated by a space and a comma. 
ONLY then you should read the next sentence. */

namespace CapitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           // bool IsUpper = false;
           // bool IsLower = false;

            while (input != "end")
            {
                string[] words = input.Split(new char[] { ' ', '!', '?', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
                var listOfWords = new List<string>();

                for (int i = 0; i < words.Length; i++)
                { 
                //  char[] letter = words[i].ToCharArray();
                
                    string firstPart = words[i].Substring(0,1).ToUpper();
                    
                    string secondPart = words[i].Substring(1, words[i].Length-1).ToLower();
                    string finalword = string.Concat(firstPart, secondPart);
                   // Console.Write("{0}, ", finalword);
                    if (!listOfWords.Contains(finalword))
                    {
                        listOfWords.Add(finalword);
                    }
                    Console.Write("{0}, ",string.Join(",", finalword));
                }
                Console.WriteLine();
                input = Console.ReadLine();
          }
            
       
       }
    }
}
    

