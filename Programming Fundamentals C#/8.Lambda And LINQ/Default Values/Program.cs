using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You will be given several key-value pairs in the following format: {key} -> {value}
Your task is to store all those pairs, until you receive the command “end”. When you receive the ending command, you must read one last line, containing the default value. Then you must change all values, which are equal to “null” with the given default value.
At the end you must print all key-value pairs, which have NOT been replaced with the default value, in descending order, by their value’s length. 
After them, you must print all key-value pairs which HAVE been replaced with the default value, in order of input.
Each key-value pair, must be printed in the following format: {key} <-> {value}
All variables in the program logic are strings.
Note: If you receive the same key twice or more times, you should update its value everytime.*/

namespace DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Dictionary<string,string> dict = new Dictionary<string, string>();

            while (input != "end")
            {
                var commandLine = input.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var key = commandLine[0];
                var value = commandLine[1];

                dict[key] = value;
                
                input = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            Dictionary<string, string> unchangedValues = dict
               .Where(x => x.Value != "null")
               .OrderByDescending(x=> x.Value.Length)
               .ToDictionary(x=> x.Key, x=>x.Value);


            Dictionary<string, string> changedValues = dict
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var item in unchangedValues)
            {
                Console.WriteLine("{0} <-> {1}",item.Key, item.Value);
            }
            foreach (var entry in changedValues)
            {
                Console.WriteLine("{0} <-> {1}", entry.Key, entry.Value);

            }


              //Console.WriteLine(string.Join("\n",unchangedValues));
            //   Console.WriteLine(string.Join("\n", changedValues));
        }
    }
}
