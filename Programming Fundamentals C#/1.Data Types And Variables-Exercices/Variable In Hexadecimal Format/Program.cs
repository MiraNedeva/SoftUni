using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a hexadecimal value out of range of the Integer type.
            string value = Convert.ToString((long)int.MaxValue + 1, 16);

            int number = Convert.ToInt32(value, 16);
            Console.WriteLine("0x{0} converts to {1}.", value, number.ToString());

        }
    }
}
