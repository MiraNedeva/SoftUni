using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You’re a carpenter at the local woodworking shop. Your client wants you to build a wooden skyscraper/cottage. A CottageScraper, he calls it. But in order to accomplish this task, he needs the trees to be taller than a certain height. The problem is that he doesn’t know what type of tree he’ll use yet, and doesn’t know how tall he wants to make the CottageScraper yet. You’ve obviously got nothing better to do, so you go to work chopping down logs until he calls you with the details.
Write a program which receives tree types and their lengths in the format “{type} -> {height}”. When you receive the command “chop chop”, it’s time to get paid.
On the next line, you will receive the type of tree that needs to be used to build the CottageScraper. On the final input line, you will receive the minimum length per tree, needed to accomplish the task. Filter the trees based on type and minimum length, making sure that you’ll only use the trees of the specified type and minimum length.
After which, calculate the total price of the CottageScraper, which includes the price of all the trees you collected up to that point. The price is calculated as being the average meters of all logs you collected, per meter of log, rounded to the second decimal place.
You’re going to charge the client 100% of the price per log for logs you’ll use in the skyscraper, and 25% of the price per log for logs you won’t use for the CottageScraper. Both of the fees are rounded to the second decimal place.
After you make the calculations, print them on the console. On the first line of the console, print “Price per meter: ${pricePerMeter:F2}”. On the second, print “Used logs price: ${usedLogsPrice:F2}”. On the third line, print “Unused logs price: ${unusedLogsPrice:F2}”. 
On the final line of the output, print “CottageScraper subtotal: ${subTotal:F2}”. */

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


