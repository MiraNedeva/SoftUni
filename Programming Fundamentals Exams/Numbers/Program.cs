using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var topFive = new List<int>();
            var final = new List<int>();

            
            var sum = numbers.Sum();
            var average = sum / numbers.Count;

          
            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < numbers.Count ; i++)
            {
                if (numbers[i] >average)
                {
                    topFive.Add(numbers[i]);
                }
                if (topFive.Count == 5)
                {
                    break;
                }
            }

            if (topFive.Count != 0)
            {
                Console.WriteLine(string.Join(" ", topFive));
            }

            else
            {
                Console.WriteLine("No");
            }


            //Console.WriteLine(string.Join(" ", numbers));





        }
    }
}
