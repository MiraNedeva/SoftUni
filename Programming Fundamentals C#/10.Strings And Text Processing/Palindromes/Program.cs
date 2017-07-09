using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on
 a single line, separated by comma and space. Use spaces, commas, dots, question marks and exclamation marks as word 
 delimiters. Print only unique palindromes, sorted lexicographically.*/

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(new char[] {' ',',','.','?'});
            List<string> palindromes = new List<string>;

            foreach (var item in words)
            {
                if (IsPalindrome(words))
                {
                    palindromes.Add(item);
                }
            }

                
        }

        private static bool IsPalindrome(string[] word)
        {
            bool result = true;


            return result;
        }
    }
}
