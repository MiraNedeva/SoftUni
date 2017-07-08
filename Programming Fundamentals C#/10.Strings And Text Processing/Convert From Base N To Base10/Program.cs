using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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
