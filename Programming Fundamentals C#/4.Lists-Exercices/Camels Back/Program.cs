using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* The city is breaking down on a camel back. You will receive a sequence of N integers, (space-separated), which will represent the buildings
in the city.  You will then receive an integer M, indicating the camel back's size. 
The camel back is a linear structure standing below the city, in such a way that it has an equal amount of buildings to its left and right.
The idea is, if every round – one building falls from the left side of the city, and one from the right side, how many rounds will it 
take for the city to stop breaking down?
As output you must print how many rounds it took before the city stopped breaking down as “{rounds} rounds”. On the next line, print what’s 
left of the city (space-separated). Format: “remaining: {buildings (space-separated)}”
If no buildings have fallen, print “already stable: {buildings (space-separated)}”
Example: city with 9 elements; Camel back size: 5
Constraints: N and M will always be odd numbers. [1-1000] and M will always be smaller or equal to N.
Exemple:    Input	                 Output
12 45 61 34 21 345 62 11 94          2 rounds
5                                    remaining: 61 34 21 345 62

9 8 7 8 2                            already stable: 9 8 7 8 2
5	*/

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
