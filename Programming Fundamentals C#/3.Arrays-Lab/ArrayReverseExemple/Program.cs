using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int length = array.Length; // get array size
            int[] reversed = new int[length];  //declare and create the reversed array
            //initialize the reversed array
            for (int i = 0; i < length; i++)
            {
                reversed[length - i - 1] = array[i];
            }
            //print the reversed array
            for (int i = 0; i < length; i++)
            {
                Console.Write(reversed[i] + " ");
            }
        }
    }
}
