using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You will be given several phone entries, in the form of strings in format:
{firstElement} : {secondElement}
The first element is usually the person’s name, and the second one – his phone number. 
The phone number consists ONLY of digits, while the person’s name can consist of any ASCII characters. 
Sometimes the phone operator gets distracted by the Minesweeper she plays all day, and gives you first the phone, and then the name. e.g. : 0888888888 : Pesho. 
You must store them correctly, even in those cases.
When you receive the command “Over”, you are to print all names you’ve stored with their phones. 
The names must be printed in alphabetical order.*/

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
