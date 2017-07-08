using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

