using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(\D+)(\d+)");

            MatchCollection matches = regex.Matches(input);
            StringBuilder result = new StringBuilder();

            var uniqueSymbols = 0;
            
            foreach (Match match in matches)
            {
                string partition = match.Groups[1].Value;
                int times = int.Parse(match.Groups[2].Value);

                string repeat = "";

                for (int i = 0; i < times; i++)
                {
                    repeat += partition.ToUpper();
                }
                result.Append(repeat);
                
            }
           uniqueSymbols = result.ToString().Distinct().Count();

            Console.WriteLine("Unique symbols used: {0}",uniqueSymbols);
            Console.WriteLine(result);
        }
    }
}
