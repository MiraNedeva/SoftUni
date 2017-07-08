using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            foreach (var letter in words)
            {
                char firstLetter = letter[0];
                char lastLetter = letter[letter.Length - 1];
                double number = int.Parse(letter.Substring(1, letter.Length - 2));


                if (! char.IsUpper(firstLetter))
                {
                    number *= 
                }
                else
                {
                     number /=    
                }
                if (char.IsUpper(lastLetter))
                {
                    number -= 
                }
                else
                {
                    number += 
                }
                result = number;
              
            }
            Console.WriteLine("{0:f2}", result);

        }
    }
}
