using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
