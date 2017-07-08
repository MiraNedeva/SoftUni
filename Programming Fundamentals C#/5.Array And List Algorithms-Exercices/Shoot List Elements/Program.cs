using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string input = Console.ReadLine();
            int lastRemoved = -1;
            string output = "";

            while (input != "stop")
            {
                if (input == "bang")
                {
                    int sum = numbers.Sum();
                    double average = sum / numbers.Count;
                  
                    if (numbers.Count == 0)
                    {
                        output = "nobody left to shoot! last one was {0}";
                        break;
                    }
                   lastRemoved = ShootElement(numbers, average);
                   DecrementElements(numbers);

                }
                else
                {
                    int number = int.Parse(input);
                    numbers.Insert(0, number);
                }

                input = Console.ReadLine();
                if (numbers.Count > 0 && output == "")
                {
                    Console.WriteLine("survivors: ",string.Join(" ",numbers));
                }
                else if (numbers.Count == 0 &&  output == "")
                {
                    Console.WriteLine("you shot them all. last one standing was {0}",lastRemoved);
                }
                else 
                {
                    Console.WriteLine(output, lastRemoved);
                }
                
            }
        }

        private static void DecrementElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

        private static int ShootElement(List<int> numbers, double average)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < average)
                {
                    numbers.RemoveAt(i);
                    Console.WriteLine("shot {0}", numbers[i]);
                    return numbers[i];
                }
            }
        }
    }
}
