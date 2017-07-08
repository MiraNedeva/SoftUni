using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandLine = input.Split(' ').ToArray();
                string command = commandLine[0];

                switch (command)
                {
                    case "exchange":

                        var index = int.Parse(commandLine[commandLine.Length - 1]);

                        if ((index >= numbers.Count) || (index < 0))
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            var firstPart = numbers.Take(index + 1).ToList();
                            var secondPart = numbers.Skip(index + 1).Take(numbers.Count - (index + 1)).ToList();

                            var finalArray = secondPart.Concat(firstPart).ToList();
                            numbers = finalArray;
                        }
                        break;

                    case "max":

                        string status = commandLine[commandLine.Length - 1];
                       
                        if (status == "even")
                        {
                            var evenMaxNums = numbers.Where(x => x % 2 == 0).ToList();

                            if (evenMaxNums.Count == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var maxEvenNum = evenMaxNums.Max();
                                var indexOfEvenMax = numbers.LastIndexOf(maxEvenNum);
                              
                                Console.WriteLine("{0}", indexOfEvenMax);
                            }
                        }

                        else if (status == "odd")
                        {

                            var oddMaxNums = numbers.Where(x => x % 2 != 0).ToList();

                            if (oddMaxNums.Count == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var maxOddNum = oddMaxNums.Max();
                                var indexOfOddMaxNum = numbers.LastIndexOf(maxOddNum);

                                
                                Console.WriteLine("{0}", indexOfOddMaxNum);
                            }
                        }
                        break;

                    case "min":

                        status = commandLine[commandLine.Length - 1];
                      
                        if (status == "even")
                        {
                           var evenMinNums = numbers.Where(x => x % 2 == 0).ToList();

                            if (evenMinNums.Count == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                //var min = 0;
                                //var indexMin = 0;
                                var minNum = evenMinNums.Min();
                                var indexOfEvenMin = numbers.LastIndexOf(minNum);

                               
                                
                                Console.WriteLine("{0}", indexOfEvenMin);
                            }
                           
                        }

                        else if (status == "odd")  
                        {
                           
                            var oddMinNums = numbers.Where(x => x % 2 != 0).ToList();

                            if (oddMinNums.Count == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var minOddNum = oddMinNums.Min();
                                var indexOfOddMinNum = numbers.LastIndexOf(minOddNum);

                                
                                Console.WriteLine("{0}",indexOfOddMinNum);   
                            }
                              
                        }

                        break;

                    case "first":

                        var countElements = int.Parse(commandLine[1]);
                        status = commandLine[commandLine.Length - 1];
                        List<int> finalNumbers = new List<int>();
                        var counter = 0;
                        var count = 0;

                        if ((countElements > numbers.Count) || (countElements < 0))
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (status == "even")
                            {
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] % 2 == 0)
                                    {
                                        if (counter < countElements)
                                        {
                                            finalNumbers.Add(numbers[i]);
                                            counter++;
                                            count++;
                                        }

                                    }
                                }
                                if (count == 0)
                                {
                                    Console.WriteLine("[]");
                                }
                                else
                                {
                                    Console.WriteLine("[{0}]", string.Join(", ", finalNumbers));
                                }
                                
                            }
                            else if (status == "odd")
                            {
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] % 2 != 0)
                                    {
                                        if (counter < countElements)
                                        {
                                            finalNumbers.Add(numbers[i]);
                                            counter++;
                                            count++;
                                        }

                                    }
                                }
                                if (count == 0)
                                {
                                    Console.WriteLine("[]");
                                }
                                else
                                {
                                    Console.WriteLine("[{0}]", string.Join(", ", finalNumbers));
                                }
                               
                            }
                        }
                       

                        break;

                    case "last":

                         countElements = int.Parse(commandLine[1]);
                        status = commandLine[commandLine.Length - 1];
                        List<int> lastNumbers = new List<int>();
                        counter = 0;
                        count = 0;

                        if ((countElements > numbers.Count) || (countElements < 0))
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (status == "even")
                            {
                                for (int i = numbers.Count - 1; i >= 0; i--)
                                {
                                    if (numbers[i] % 2 == 0)
                                    {
                                        if (counter < countElements)
                                        {
                                            lastNumbers.Add(numbers[i]);
                                            counter++; 
                                            count++;
                                        }
                                    }
                                }
                                lastNumbers.Reverse();
                                if (count == 0)
                                {
                                    Console.WriteLine("[]");
                                }
                                else
                                {
                                    Console.WriteLine("[{0}]", string.Join(", ", lastNumbers));
                                }
                            }
                            else if (status == "odd")
                            {
                                for (int i = numbers.Count -1; i >= 0; i--)
                                {
                                    if (numbers[i] % 2 != 0)
                                    {
                                        if (counter < countElements)
                                        {
                                            lastNumbers.Add(numbers[i]);
                                            counter++;
                                            count++;
                                        }

                                    }
                                }
                                lastNumbers.Reverse();
                                if (count == 0)
                                {
                                    Console.WriteLine("[]");
                                }
                                else
                                {
                                    Console.WriteLine("[{0}]", string.Join(", ", lastNumbers));
                                }
                            }
                        }
                        
                        break;
                        
                }

                   input = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
    }
}
