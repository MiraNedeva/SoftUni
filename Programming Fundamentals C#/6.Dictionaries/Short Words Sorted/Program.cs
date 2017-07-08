using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', '.', ',', ':', ';', '(', ')', '[', ']', '\'', '/', '!', '?', ' ' };
            string sentence = Console.ReadLine().ToLower();

            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var result = words.Where(w => w.Length < 5);
            var orderedResult = result.OrderBy(w => w ).Distinct();

            Console.WriteLine(string.Join (", ", orderedResult));


        }
    }
}
