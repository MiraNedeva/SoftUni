using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            var newNums = new List<int>();
                
            while (input != "end")
            {
                string[] inputParams = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = inputParams[0];
                switch (command)
                {
                    case "reverse":
                        var startIndex = int.Parse(inputParams[2]);
                        var countElements = int.Parse(inputParams[4]);

                        /* List<string> portion = new List<string>();
                         for (int i = startIndex; i < startIndex + countElements; i++)
                         {
                             portion.Add(numbers[i]);
                         }
                         numbers.RemoveRange(startIndex, countElements);
                         portion.Reverse();
                         numbers.InsertRange(startIndex, portion);*/
                        if (((countElements < 0) || (startIndex < 0)) || (startIndex + countElements > numbers.Count) || (startIndex >= numbers.Count))
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        numbers.Reverse(startIndex, countElements);
                        break;

                    case "sort":
                         startIndex = int.Parse(inputParams[2]);
                         countElements = int.Parse(inputParams[4]);

                        if (((countElements < 0) || (startIndex < 0))|| (startIndex + countElements > numbers.Count)||(startIndex >= numbers.Count))
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        numbers.Sort(startIndex, countElements, null);
                        break;

                    case "rollLeft":
                        
                        countElements = int.Parse(inputParams[1]);

                        if (countElements < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        int rotations = countElements % numbers.Count;
                        for (int i = 0; i < rotations; i++)
                        {
                            string firstElement = numbers[0];

                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = firstElement;
                        }
                          
                        break;

                    case "rollRight":
                        countElements = int.Parse(inputParams[1]);

                        if(countElements < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                         rotations = countElements % numbers.Count;
                        for (int i = 0; i < rotations; i++)
                        {
                            string lastElement = numbers[numbers.Count - 1];

                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = lastElement;
                        }

                        break;
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", " ,numbers));
        }
    }
}
