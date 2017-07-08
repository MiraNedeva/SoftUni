using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerbianUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var ConcertInfo = new Dictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();

            int position = input.IndexOf("@"); // positciq na @
            string singer = input.Substring(0, position - 1); //

            Console.WriteLine("{0}",singer);

            int pos = input.IndexOf("1");


          
               
            }

           


        }
    }
