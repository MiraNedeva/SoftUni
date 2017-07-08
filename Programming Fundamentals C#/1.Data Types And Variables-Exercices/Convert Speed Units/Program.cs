using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse (Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());


            float speedInMetersPerSecond = (float) (distanceInMeters / ((hours * 3600m) + (minutes * 60m) + (seconds)));
            Console.WriteLine(speedInMetersPerSecond);

            float speedInKmPerHour = (float) ((distanceInMeters * 0.001m) / (hours + (minutes / 60m) + (seconds / 3600m)));
            Console.WriteLine(speedInKmPerHour);

            float speedInMilesPerHour = (float) ((distanceInMeters / 1609f) / (hours + (minutes / 60f) + (seconds / 3600f)));
            Console.WriteLine(speedInMilesPerHour);
        }
    }
}
