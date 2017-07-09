using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are given the coordinates of four points in the 2D plane. The first and the second pair of points form two different 
lines. Print the longer line in format "(X1, Y1)(X2, Y2)" starting with the point that is closer to the center of the 
coordinate system (0, 0) (You can reuse the method that you wrote for the previous problem). If the lines are of equal 
length, print only the first one.*/

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double length1 = GetLine1Length(x1, y1, x2, y2);
            double length2 = Getline2Length(x3, y3, x4, y4);
            //Console.WriteLine(length1);
            //Console.WriteLine(length2);

            if (length2 > length1)
            {
               GetCloserPointLine2(x3, y3, x4, y4);
            }
            else
            {
                GetCloserPointLine1(x1, y1, x2, y2);
            }

        }
                             //////////////////////Methods/////////////////////

        static double GetLine1Length(double x1, double y1, double x2, double y2)
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return length;
        }

        static double Getline2Length(double x3, double y3, double x4, double y4)
        {
            double length = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            return length;

        }

        static void GetCloserPointLine1(double x1, double y1, double x2, double y2)
        {
                 //string coordinates = " ";
            if (Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(x2, 2) + Math.Pow(y2, 2))
            {
                // coordinates = $"({x1},{y1}),({x2},{y2})";
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2,y2);
            }

            else
            {
                //coordinates = $"({x2},{y2}),({x1},{y1})";
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
               //return (coordinates);
        }

        static void GetCloserPointLine2(double x3, double y3, double x4, double y4)
        {
              //string coordinates = " ";
            if (Math.Pow(x3, 2) + Math.Pow(y3, 2) <= Math.Pow(x4, 2) + Math.Pow(y4, 2))
            {
                //coordinates = $"({x3},{y3}{x4},{y4})";
                Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
            }

            else
            {
                //coordinates = $"({x4},{y4}{x3},{y3})";
                Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
            }
               //return (coordinates);
        }
    }
}