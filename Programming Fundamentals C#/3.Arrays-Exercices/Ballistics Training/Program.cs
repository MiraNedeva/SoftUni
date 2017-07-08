using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            int [] firingPosition = new int[2];

            for (int i = 0; i < commands.Length; i++)
            {
                if (i % 2 == 0 && commands[i] == "up")
                {
                    firingPosition[1] += int.Parse(commands[i + 1]);
                }
                else if (i % 2 == 0 && commands[i] == "down")
                {
                    firingPosition[1] -= int.Parse(commands[i + 1]);
                }
                else if (i % 2 == 0 && commands[i] == "right")
                {
                    firingPosition[0] += int.Parse(commands[i + 1]);
                }
                else if (i % 2 == 0 && commands[i] == "left")
                {
                    firingPosition[0] -= int.Parse(commands[i + 1]);
                }
            }

            if (targetCoordinates[0] == firingPosition[0] && targetCoordinates[1] == firingPosition[1])
            {
                Console.WriteLine("firing at [{0}, {1}] \ngot 'em!", firingPosition[0], firingPosition[1]);
            }
            else
            {
                Console.WriteLine("firing at [{0}, {1}] \nbetter luck next time...", firingPosition[0], firingPosition[1]);
            }

        }
    }
}
