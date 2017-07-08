using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Read a text, extract its words, find all short words (less than 5 characters) and print them alphabetically, in lowercase.
//•	Use the following separators: . , : ; ( ) [ ] " ' \ / ! ? (space).
//•	Use case-insensitive matching.
//•	Remove duplicated words.


namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .Select(w => w.ToLower())
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ",words));
                 

        }
    }
}
