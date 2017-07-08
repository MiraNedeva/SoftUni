using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You will be given several input lines containing info about a key, an inner key and inner value, separated by a SPACE.
Your task is to store every inner key and inner value, in every key’s value. Check the Examples for more info.
If you receive the command “flatten {key}”, you must flatten all the inner keys and inner values at the given key, or in other words, CONCATENATE them.
When you receive the command “end” the input ends. You must print all keys and their inner-keys and inner-values. Flattened inner keys and inner values, must be printed AFTER all else.
The keys must be printed in descending order of their length. 
All inner-keys must be printed in ascending order of their length.
Flattened Values must be printed in order of input.
The format of printing is:                   Flattened values should be printed like this         
{key}                                        {key}
1. {innerKey} – {innerValue}                 . . .         
2. {innerKey} – {innerValue}                 x. {flattenedValue}          
3. {innerKey} – {innerValue}                 (x+1). {innerKey} – {innerValue}
. . .                                        . . .

If you receive an inner key that already exists, replace its value with the new given one. */

namespace FlattenDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var results = new Dictionary<string,Dictionary<string, string>>();

            while (input != "end")
            {
                string[] command = input.Split(' ').ToArray();
                
                string innerKey = command[1];
                string innerValue = command[2];

                if (command[0] == "flatten")
                {

                    if (!results.ContainsKey(command[0]))
                    {
                        results[command[0]] = new Dictionary<string, string>();
                    }
                    if (!results[command[0]].ContainsKey(innerKey))
                    {
                        results[command[0]][innerKey] = string.Empty;
                    }
                    results[command[0]][innerKey] = innerValue;
                }

                else
                {
                    string key = command[1];
                }




              input = Console.ReadLine();
            }










            // Console.WriteLine(string.Join(" ",results));

        }
    }
}
