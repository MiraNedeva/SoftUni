using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            //65-90
            //97-122
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















/*  foreach (char letter in word)
                {

                    if (char.IsUpper(letter))
                    {
                        countU++;
                    }
                    else if (char.IsLower(letter))
                    {
                        countL++;
                    }
                    else
                    {
                        countM++;
                    }
                }

                if (words.Length == countL)
                {
                    LowCaseWords.Add(words);
                }
                else if (words.Length == countU)
                {
                    UpCaseWords.Add(words);
                }
                else 
                {
                    MixtedCaseWords.Add(words);
                }
            }
*/