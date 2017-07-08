using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim();
            var phones = new SortedDictionary<string, string>();

            while (input != "Over")
            {
                var word = input.Trim().Split();

                var firstElement = word[0];
                var lastElement = word[word.Length - 1];

                var number = 0;
                if (int.TryParse(firstElement, out number))
                {
                    var temp = firstElement;
                    firstElement = lastElement;
                    lastElement = temp;
                }

                if (!phones.ContainsKey(firstElement))
                {
                    phones[firstElement] = lastElement;
                }
                
                input = Console.ReadLine();
            }
            foreach (var item in phones)
            {
                var first = item.Key;
                var last = item.Value;
                Console.WriteLine($"{first} -> {last}");
            }
        }
    }
}
