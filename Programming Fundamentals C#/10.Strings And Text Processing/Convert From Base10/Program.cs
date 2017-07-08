using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//compris
namespace ConvertFromBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var basedNnumber = int.Parse(input[0]);
            var based10Number = BigInteger.Parse(input[1]);

            var result = ConvertFromBase10ToBaseN( based10Number, basedNnumber);

            Console.WriteLine(result);
        }

        private static object ConvertFromBase10ToBaseN(BigInteger based10Number, int basedNnumber)
        {
            var result = string.Empty;
            

            while (based10Number != 0)
            {
                var remaider = based10Number % basedNnumber;
                result = remaider + result;
                based10Number = based10Number/ basedNnumber;
            }

            return result;
        }
    }
}
