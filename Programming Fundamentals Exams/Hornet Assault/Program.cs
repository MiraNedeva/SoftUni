using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] behives = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> finalBehives = new List<long>();
            
            long hornetsPower = 0L;

            for (int i = 0; i < behives.Length; i++)
            {
               
                hornetsPower = hornets.Sum();

                if (behives[i] < hornetsPower)
                {
                    behives[i] = 0;
                    
                    
                }
                else if(behives[i] > hornetsPower)
                {
                    hornets.RemoveAt(0);
                    
                    behives[i] = behives[i] - hornetsPower;
                    finalBehives.Add(behives[i]);
                   
                }
                else 
                {
                    hornets.RemoveAt(0);

                    behives[i] -= hornetsPower;
                }
               
               
            }

            if (finalBehives.Count == 0)
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
            else
            {
                Console.WriteLine(string.Join(" ", finalBehives));
            }
           
           
        }
    }
}
