using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    /*if (altitude <= 0)
                    {
                        break;
                    }*/
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
