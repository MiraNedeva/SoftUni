using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetIpsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentenseReg = new Regex(@"^[A-Z][^\.]*\.$");
            var wordReg = new Regex(@"[^\s,\.]+");

            var inputLine = Console.ReadLine();

            while (!inputLine.Equals("Worm Ipsum"))
            {
                var sentenceMatch = sentenseReg.Match(inputLine);

                if (sentenceMatch.Success)
                {
                    var wordMatches = wordReg.Matches(inputLine);

                    foreach (Match match in wordMatches)
                    {
                        var currentWord = match.Value;

                        if (currentWord.Length != currentWord.Distinct().Count())
                        {
                            var symbol = currentWord.GroupBy(x => x)
                                .OrderByDescending(x => x.Count())
                                .First().Key;
                            
                            var newWord = string.Concat(Enumerable.Repeat(symbol, currentWord.Length));
                            inputLine = Regex.Replace(inputLine, currentWord, newWord);
                        }
                    }
                    Console.WriteLine(inputLine);

                }
                inputLine = Console.ReadLine();

            }
        }
    }
}
