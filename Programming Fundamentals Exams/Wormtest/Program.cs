using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            long lengthInM = long.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double lengthInCm = lengthInM * 100;
          
            var remainder = (lengthInCm % width);
            //Console.WriteLine(remainder);

            if (remainder != 0)
            {
                double percentage = (lengthInCm / width) * 100;
                Console.WriteLine("{0:F2}%", percentage);
                
            }
            else if( remainder == 0)
            {
                double productOfNumbers = lengthInCm * width;
                Console.WriteLine("{0:F2}", productOfNumbers);
            }
            else
            {
                double productOfNumbers = lengthInCm * width;
                Console.WriteLine("{0:F2}", productOfNumbers);
            }
        
        }
    }
}
