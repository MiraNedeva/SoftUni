using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var result = new Dictionary<string, HashSet<int>>();

            while (input[0] != "Aggregate")
            {
                var region = input[0];
                var shell = int.Parse(input[1]);

                if (! result.ContainsKey(region))
                {
                    result[region] = new HashSet<int>();
                }
                result[region].Add(shell);

                input[0] = Console.ReadLine();
            }

            foreach (var item in result)
            {
                string region = item.Key;
                HashSet<int> shells = item.Value;

                Console.WriteLine($"{region} -> {string.Join(", ", shells)} ({Math.Ceiling(shells.Sum() - shells.Average())})");

               
            }
        }
    }
}
