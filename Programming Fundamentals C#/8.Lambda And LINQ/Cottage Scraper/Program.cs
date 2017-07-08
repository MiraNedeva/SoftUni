using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var treeTypes = new Dictionary<string, List<int>>();

            while (input != "chop chop")
            {
                string[] command = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string type = command[0];
                var height = int.Parse(command[1]);

                if (!treeTypes.ContainsKey(type))
                {
                    treeTypes[type] = new List<int>();
                }
                treeTypes[type].Add(height);

                input = Console.ReadLine();
            }

            string neededType = Console.ReadLine();
            var neededHeight = int.Parse(Console.ReadLine());
            var totalMeters = 0;
            var count = 0.0;

            foreach (var item in treeTypes.Values)
            {
                totalMeters += item.Sum();
                count += item.Count();
            }

            var pricePerMeter = Math.Round(totalMeters / (double)count, 2);

            var usedLogs = new List<int>();

            foreach (var type in treeTypes)
            {
                if (type.Key == neededType)
                {
                    usedLogs = type.Value.Where(x => x >= neededHeight).ToList();
                }
            }

            var usedLogPrice = Math.Round(usedLogs.Sum() * pricePerMeter, 2);

            var unusedLogs = new List<int>();

            foreach (var type in treeTypes)
            {
                if (type.Key != neededType)
                {
                    foreach (var item in type.Value)
                    {
                        unusedLogs.Add(item);
                    }
                }
                else
                {
                    foreach (var item in type.Value)
                    {
                        if (item < neededHeight)
                        {
                            unusedLogs.Add(item);
                        }
                    }
                }
            }
            var unusedLogPrice = Math.Round(unusedLogs.Sum() * pricePerMeter * 0.25,2);
            var totalPrice = usedLogPrice + unusedLogPrice;

            Console.WriteLine("Price per meter: ${0:F2}", pricePerMeter);
            Console.WriteLine("Used logs price: ${0:F2}", usedLogPrice);
            //Console.WriteLine(string.Join(" ", unusedLogs));
            Console.WriteLine("Unused logs price: ${0:F2}", unusedLogPrice);
            Console.WriteLine("CottageScraper subtotal: ${0:F2}", totalPrice);
        }
   }
}


