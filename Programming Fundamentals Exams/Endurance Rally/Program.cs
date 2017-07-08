using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split(' ').ToArray();
            var trackLayout = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //var firstLetter = 0;

            var fuel= 0.0;

            for (int i = 0; i < drivers.Length; i++)
            {
                char[] currentDriver = drivers[i].ToCharArray();

                fuel= currentDriver.First();
                

                for (int j = 0; j < trackLayout.Length; j++)
                {
                   
                        if (!checkpoints.Contains(j))
                        {
                            fuel -= trackLayout[j];
                            
                        }
                       
                        else
                        {
                            fuel += trackLayout[j];
                            
                        }
                    if (fuel <= 0)
                    {
                        Console.WriteLine("{0} - reached 0", drivers[i]);
                        break;
                    }

                }
                if (fuel > 0)
                {
                    Console.WriteLine("{0} - fuel left {1:F2}", drivers[i],fuel);
                }
                
              
            }

      
        }
    }
}
