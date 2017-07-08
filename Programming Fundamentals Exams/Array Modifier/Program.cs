using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
           long[] initialArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            string command = Console.ReadLine();
            

            while (command != "end")
            {
                string[] commandParams = command.Split(' ').ToArray();

                switch (commandParams[0])
                {
                    case "swap":
                        long index1 = long.Parse(commandParams[1]);
                        long index2 = long.Parse(commandParams[commandParams.Length-1]);

                        long temp = initialArray[index1];
                        initialArray[index1] = initialArray[index2];
                        initialArray[index2] = temp;
                        
                        break;

                    case "multiply":
                        var index11 = long.Parse(commandParams[1]);
                        var index22 = long.Parse(commandParams[commandParams.Length - 1]);
                        initialArray[index11] *= initialArray[index22];
                      
                        break;

                    case "decrease":

                        for (int i = 0; i < initialArray.Length; i++)
                        {
                            initialArray[i]--;
                        }
                       
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",initialArray));
        }
    }
}
