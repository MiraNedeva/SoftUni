using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
