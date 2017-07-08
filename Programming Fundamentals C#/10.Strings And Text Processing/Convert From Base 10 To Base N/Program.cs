using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {

            var basedNnumber = int.Parse(Console.ReadLine());
            var based10Number = int.Parse(Console.ReadLine());

            List<int> baseN = new List<int>();
            var remainder = 0;

            while (based10Number !=0)
            {
                remainder = based10Number % basedNnumber;
                // i dobavqme remaindera v nqkakvuv list koito posle reversvame
                if (! baseN.Contains(remainder))
                {
                    baseN.Add(remainder);
                    baseN.Reverse();
                }
               
                based10Number = based10Number / basedNnumber;
                
            }
            
        }
    }
}
