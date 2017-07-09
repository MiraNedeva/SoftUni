using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a method to calculate the distance between two points p1 {x1, y1} and p2 {x2, y2}. 
Write a program to read two points (given as two integers) and print the Euclidean distance between them.*/

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var firstPoint = new Point
            {
                X = firstPointParts[0],
                Y = firstPointParts[1]
            };

            var secondPointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var secondPoint = new Point
            {
                X = secondPointParts[0],
                Y = secondPointParts[1]
            };

            var finalDistance = Distance(firstPoint, secondPoint);

            Console.WriteLine("{0:F3}", finalDistance);

        }
        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);

            var finalDistance = Math.Sqrt(squareX + squareY);

            return finalDistance;
        }
    }
}
