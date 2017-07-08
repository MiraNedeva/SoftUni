using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are in a battery manufacturing plant. Your task is to stress test the latest batch of batteries for longevity.
You will receive an array of doubles on the console (first line, space-separated), indicating the capacities of the different batteries 
in the batch (in mAh). On the next line, you will receive the usage per hour for each battery as an array of doubles (second line, space-separated).
Next, you will receive the amount of hours you have to stress test each battery for (as an integer). Each of the batteries drains by its
capacity until either the testing hours are over, or the battery dies (reaches 0 capacity).
Print the status of all the batteries at the end of the testing session (in percentage). If any batteries die, along with the percentage, 
print how many hours it took. The capacity and percentage are rounded to the 2nd decimal point.*/

namespace Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] capacities = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int hours = int.Parse(Console.ReadLine());
            
            var diff = 0.0;
            var totalUsage = 0.0;

            for (int i = 0; i < capacities.Length; i++)
            {
                totalUsage = usagePerHour[i] * hours;

                if (totalUsage < capacities[i])
                {
                    diff = capacities[i] - totalUsage;
                    var percentage = (diff / capacities[i]) * 100;
                    Console.WriteLine("Battery{0}: {1:F2} mAh ({2:F2}%)",i+1,diff, percentage);
                }
                else
                {
                    Console.WriteLine("Battery{0}: dead",i+1);
                }
            }
        }
    }
}
