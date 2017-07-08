using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    

