using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var wormhole = 0;
            //var currentPosition = 0;
            var wormholeIndex = 0;
            var steps = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == 0)
                {
                    steps++;
                    continue;

                }
                else
                {
                    wormhole = numbers[i];
                    wormholeIndex = i;

                    numbers[wormholeIndex] = 0;

                    i = wormhole;
                    steps++;
                 
                }
            
                    }
                
            Console.WriteLine(steps);
            }
        }
    }


