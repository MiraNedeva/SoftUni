using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on) , and every even – quantity. Your task is to collect the resources and print them each on a new line. 
Print the resources and their quantities in format:
{resource} –> {quantity}
The quantities inputs will be in the range [1 … 2 000 000 000] */

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();

            string resourceType = Console.ReadLine();

            while (!resourceType.Equals("stop"))
            {
                long quantity = long.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resourceType))
                {
                    resources.Add(resourceType, 0);
                }

                resources[resourceType] += quantity;

                resourceType = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);

            }
        }
            
        }
    }

