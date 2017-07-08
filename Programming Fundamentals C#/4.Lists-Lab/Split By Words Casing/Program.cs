using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Read a text, split it into words and distribute them into 3 lists.
	Lower-case words like “programming”, “at” and “databases” – consist of lowercase letters only.
	Upper-case words like “PHP”, “JS” and “SQL” – consist of uppercase letters only.
	Mixed-case words like “C#”, “SoftUni” and “Java” – all others.
Use the following separators between the words: , ; : . ! ( ) " ' \ / [ ] space
Print the 3 lists */

namespace SplitByWordsCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
               .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToList();

            List<string> UpCaseWords = new List<string>();
            List<string> LowCaseWords = new List<string>();
            List<string> MixtedCaseWords = new List<string>();

            foreach (var word in words)
            {
                int countL = 0;
                int countU = 0;
                int countM = 0;


              foreach (char letter in word)
               {
                if (letter >= 65 &&  letter<= 90)
                {
                        countU++;
                }
                else if (letter >= 97 && letter <= 122)
                    {
                        countL++;
                     }
               
              }  
                if (word.Length == countU)
                {
                    UpCaseWords.Add(word);
                }
               else if (word.Length == countL)
                {
                    LowCaseWords.Add(word);
                }
                else
                {
                    MixtedCaseWords.Add(word);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", LowCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", MixtedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", UpCaseWords));
        }
    }
}
