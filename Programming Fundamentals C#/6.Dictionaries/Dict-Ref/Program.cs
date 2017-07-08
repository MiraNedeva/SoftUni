using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You have been tasked to create a referenced dictionary, or in other words a dictionary, which knows how to reference itself.
You will be given several input lines, in one of the following formats:
•	{name} = {value}
•	{name} = {secondName}
The names will always be strings, and the values will always be integers.
In case you are given a name and a value, you must store the given name and its value. If the name already EXISTS, you must CHANGE its value with the given one.
In case you are given a name and a second name, you must store the given name with the same value as the value of the second name. If the given second name DOES NOT exist, you must IGNORE that input.
When you receive the command “end”, you must print all entries with their value, by order of input, in the following format:
{entry} === {value} */

namespace Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var resultDict = new Dictionary<string, int>();

            while (input != "end")
            {
                var word = input.Split(' ');      // [0] cash; [1] = ;[2] 500;

                var firstElement = word[0];
                var lastElement = word[word.Length - 1];

                var number = 0;

                if (int.TryParse(lastElement, out number)) 
                {
                    resultDict[firstElement] = number;
                }
                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        var referencedValue = resultDict[lastElement];
                        resultDict[firstElement] = referencedValue;
                    }
                    
                }
                
                input = Console.ReadLine();
            }
            foreach (var item in resultDict)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
