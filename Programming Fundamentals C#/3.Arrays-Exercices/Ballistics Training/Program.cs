using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are the anti-aircraft operator, trying to shoot down the airplane from the previous problem. You’ll be given 
instructions to get to the current coordinates of the plane. Shoot it down.
You will be given an array which holds 2 numbers – the target X and Y coordinates of the plane.
Afterwards, you will be given a second array, which holds a sequence of left / right / up / down commands and numbers. 
We start at position {x=0, y=0}. Manipulate the firing position in the following way:
•	Up increases y by the next number.
•	Down decreases y by the next number.
•	Left decreases x by the next number.
•	Right increases x by the next number.
After you process all the commands, print “firing at [{x}, {y}]”. After that, check if the firing position coordinates line
 up with the target coordinates. If they do, print “got 'em!”. If not – print “better luck next time...”
*/

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
