using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/* Write a program that takes a base-N number and converts it to a base-10 number (0 to 1050), where 2 <= N <= 10.
The input consists of 1 line containing two numbers separated by a single space. The first number is the base N to which you have to convert. The second one is the base N number to be converted. 
Do not use any built in converting functionality, try to write your own algorithm.*/

namespace ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            var basedNnumber = int.Parse(input[0]);
            var based10Number = BigInteger.Parse(input[1]);

            var result = ConvertBaseNToBase10(based10Number, basedNnumber);

            Console.WriteLine(result);
        }
        
        private static object ConvertBaseNToBase10(BigInteger based10Number, int basedNnumber)
        {
            var numberAsString = based10Number.ToString();

            var sum = new BigInteger(0);

            for (int power = 0; power < numberAsString.Length; power++)
            {
                var num = int.Parse(numberAsString[numberAsString.Length - 1 - power].ToString());
                var result = num * BigInteger.Pow(basedNnumber, power);
                sum += result;
            }

            return sum;             
        }
    }
}
