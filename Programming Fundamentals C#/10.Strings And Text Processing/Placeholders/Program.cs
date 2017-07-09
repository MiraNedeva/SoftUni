using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Placeholders in C# are really comfortable for use, right? How about you implement them to see just how easy they are.
You will be given input lines containing a string with placeholders, i.e. “This is {0}. And that is {1}.”.
The input lines will be in the following format:
{someString} -> {someElement}, {someElement2}
You have to replace the placeholders in the string, with the elements given after that, separated by a comma and a space. 
Each element has an index, so you must give them the right order. The first given element goes where the 0 is, the second to the 1, and so on…
Print each string, with its replaced placeholders, RIGHT after you’ve read it, and BEFORE reading the next one.
The input ends when you receive the command “end”. */

namespace Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputLine = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string sentence = inputLine[0].Trim();
                string[] elements = inputLine[1].Trim()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    string currentPlaceholder = "{" + i + "}";
                    sentence = sentence.Replace(currentPlaceholder, elements[i]);
                }

                Console.WriteLine(sentence);

                input = Console.ReadLine();
            }
        }
    }
}
