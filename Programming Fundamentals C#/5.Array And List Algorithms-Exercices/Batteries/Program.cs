using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
