using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are an airplane pilot, trying to maneuver your airplane to safety from an unknown danger.
An array holds a sequence of up / down commands and numbers. Its first element always holds the initial altitude. The 
command up increases the altitude by the next number, while the command down decreases the altitude by the next number.
If at any point the altitude becomes either zero or negative, print “crashed” and end the program. If by the end, 
the altitude is positive, however, print “got through safely. current altitude: {altitude}m”.
Exemple:   Input	                                          Output
300 up 3 down 7 up 5	                                      got through safely. current altitude: 301m
50 up 2 down 20 up 3 down 36 up 1 down 2 up 2	              crashed   */

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandes = Console.ReadLine().Split(' ').ToArray();

            double altitude = double.Parse(commandes[0]);
          

            for (int i = 0; i < commandes.Length; i++)
            {
                if (i % 2 != 0 && commandes[i] == "up")
                {
                    altitude += double.Parse(commandes[i + 1]);
                }
                else if(i % 2 != 0 && commandes[i] == "down")
                {
                    altitude -= double.Parse(commandes[i + 1]);
                    
                }
            }
            if (altitude <= 0)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine("got through safely. current altitude: {0}m", altitude);
            }
            
        }
    }
}
