using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelsBack
{
    class Program
    {
        static void Main(string[] args)
        {
            var building = Console.ReadLine().Split().Select(int.Parse).ToList();
            var camelsBackSize = int.Parse(Console.ReadLine());

            var rounds = 0;

            while (building.Count !=  camelsBackSize)
            {
                building.RemoveAt(0);
                building.RemoveAt(building.Count - 1);
                rounds++;
            }
            if (rounds == 0)
            {
                Console.Write("already stable: ");
                Console.Write(string.Join(" ", building));
            }
            else
            {
                Console.WriteLine("{0} rounds", rounds);
                Console.Write("remaining: ");
                Console.Write(string.Join(" ",building));
            }

        }
    }
}
