using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
