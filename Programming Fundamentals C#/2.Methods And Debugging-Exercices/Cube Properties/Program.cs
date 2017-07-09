using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that can calculate the length of the face diagonals, space diagonals, volume and surface area of a cube 
(http://www.mathopenref.com/cube.html) by a given side. On the first line you will get the side of the cube. 
On the second line is given the parameter (face, space, volume or area).
Output should be rounded to the second digit after the decimal point */

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            if (type == "face")
            {
                Console.WriteLine("{0:f2}", face(side));
            }
            else if (type == "space")
            {
                Console.WriteLine("{0:f2}", space(side));
            }
            else if (type == "area")
            {
                Console.WriteLine("{0:f2}", area(side));
            }
            else if (type == "volume")
            {
                Console.WriteLine("{0:f2}", volume(side));
            }
        }


        static double face(double side)
        {
            double result = Math.Sqrt(2 * (side * side));
            return result;
        }

        static double space(double side)
        {
            double result = Math.Sqrt(3 * (side * side));
            return result;
        }
        static double area(double side)
        {
            double result = 6 * (side * side);
            return result;
        }
        static double volume(double side)
        {
            double result = side * side *side;
            return result;
        }

    }
}




