using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormsWorldParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<string, Dictionary<string, int>>();

            while (input != "quit")
            {
                string[] inputParams = input
                    .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x=>x.Trim())
                    .ToArray();

                string wormName = inputParams[0];
                string teamName = inputParams[1];
                int score = int.Parse(inputParams[inputParams.Length - 1]);

                bool hasWormName = false;

                foreach (var kvp in dict)
                {
                    if (kvp.Value.ContainsKey(wormName))
                    {
                        hasWormName = true;
                    }
                }

                if (hasWormName == false)
                {
                    if (!dict.ContainsKey(teamName))
                    {
                        dict.Add(teamName, new Dictionary<string, int>());
                    }
                    if (!dict[teamName].ContainsKey(wormName))
                    {
                        dict[teamName][wormName] = 0;
                    }

                    dict[teamName][wormName] = score;
                }

                input = Console.ReadLine();
            }

            
            var count = 1;

            foreach (var item in dict.OrderByDescending(w => w.Value.Sum(s => s.Value))
                .ThenByDescending(w=>w.Value.Average(s=>s.Value)))
            {
                  var  sum = item.Value.Values.Sum();
             
                Console.WriteLine("{0}. Team: {1} - {2}",count, item.Key, sum);
                count++;

                foreach (var entry in item.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine("###{0} : {1}", entry.Key, entry.Value);
                }
            }
        }
    }
}
