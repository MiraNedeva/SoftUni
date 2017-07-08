using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine().ToLower();
            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int result = GetMax(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = Console.ReadLine()[0];
                char secondChar = Console.ReadLine()[0];
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);


            }
            else if (type == "string")
            {
                string firstStr = Console.ReadLine();
                string secondStr = Console.ReadLine();
                string result = GetMax(firstStr, secondStr);
                Console.WriteLine(result);

            }

        }

        private static int GetMax(int first, int second)
        {

            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            return second;
        }

     private  static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar.CompareTo(secondChar) > 0)
            {
                return firstChar;
            }
            return secondChar;
        }

        private static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) > 0)
            {
                return firstString;
            }
            return secondString;
        }
    }
}
