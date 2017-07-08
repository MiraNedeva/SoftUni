using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniWaterSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAmountOfWater = int.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var capacityOfBottle = int.Parse(Console.ReadLine());
            var positiions = new List<int>();


            double neededWater = 0;
            double waterSum = 0;
            double leftWater = 0;

            // CASE WHEN NUMBER IS EVEN
            if (totalAmountOfWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Count; i++)
                {

                    waterSum += capacityOfBottle - bottles[i];
                    if (totalAmountOfWater >= waterSum)
                    {
                        leftWater = totalAmountOfWater - waterSum;
                    }
                    else
                    {
                        neededWater = waterSum - totalAmountOfWater;
                        positiions.Add(i);
                    }
                }
            }
            // CASE WHEN NUMBER IS ODD
            else if (totalAmountOfWater % 2 == 1)
            {

                for (int i = bottles.Count - 1; i >= 0; i--)
                {
                    waterSum += capacityOfBottle - bottles[i];
                    if (totalAmountOfWater >= waterSum)
                    {
                        leftWater = totalAmountOfWater - waterSum;
                    }
                    else
                    {
                        neededWater = waterSum - totalAmountOfWater;
                        positiions.Add(i);
                    }

                }
            }
            if (waterSum <= totalAmountOfWater)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine("Water left: {0}l.", leftWater);
            }
            else
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", positiions.Count);
                Console.WriteLine("With indexes: {0}", string.Join(", ", positiions));
                Console.WriteLine("We need {0} more liters!", neededWater);
            }
        }
    }
}