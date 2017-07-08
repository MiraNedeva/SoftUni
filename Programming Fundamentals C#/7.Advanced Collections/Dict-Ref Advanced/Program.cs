using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Remember the DIct-Ref Problem from the previous exercise? Well this one is an Advanced Version.
You will begin receiving input lines containing information in one of the following formats:
•	{key} -> {value1, value2, value3. . .}
•	{key} -> {otherKey}
The keys will always be strings, and the values will always be integers, separated by a comma and a space. 
If you are given a key and values, you must store the values to the given key. If the key already exists, you must add the given values to the old ones.
If you are given a key and another key, you must copy the values of the other key to the first one. If the other key does not exist, this input line must be IGNORED.
When you receive the command “end”, you must stop reading input lines, and you must print all keys with their values, in the following format:
{key} === {value1, value2, value3. . .} */

namespace DictRefAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, List<int>>();

        
            var number = 0;
            while (input != "end")
            {
                string[] inputLine = input.Split(new char[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var currentKey = inputLine[0];
                var secondValue = inputLine[1];

                if (int.TryParse(secondValue, out number))
                {
                    if (!dict.ContainsKey(currentKey))
                    {
                        dict[currentKey] = new List<int>();
                    }
                    for (int i = 1; i < inputLine.Length; i++)
                    {
                        dict[currentKey].Add(int.Parse(inputLine[i]));
                    }
                }
                else
                {
                    string otherKey = inputLine[1];
                    if (dict.ContainsKey(otherKey))
                    {
                        dict[currentKey] = new List<int>(dict[otherKey]);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine("{0} === {1}",item.Key, string.Join(", ",item.Value));
            }
     }
  }
}

