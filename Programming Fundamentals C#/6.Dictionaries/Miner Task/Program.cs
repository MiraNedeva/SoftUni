using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

