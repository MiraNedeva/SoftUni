using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", TriangleArea(side, height));
                    break;

                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", SquareArea(sideSquare));
                    break;

                case "rectangle":
                    double widht = double.Parse(Console.ReadLine());
                    double heightRect = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", RectangleArea(widht, heightRect));
                    break;

                case "circle":

                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CircleArea(radius));
                    break;
            }
        }


        /////////// Methods///////////
        static double TriangleArea(double side, double height)
        {
            double result = (side * height) / 2;
            return result;
        }

        static double SquareArea(double side)
        {
            double result = side * side;
            return result;
        }

        static double RectangleArea(double width, double height)
        {
            double result = width * height;
            return result;
        }

        static double CircleArea(double radius)
        {
            double result = Math.PI * (radius * radius);
            return result;
        }
    }
}

