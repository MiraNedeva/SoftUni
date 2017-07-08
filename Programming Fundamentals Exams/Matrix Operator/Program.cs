using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRows; i++)
            {
                var currentRow = Console.ReadLine().Split(' ');

            }
            string command = Console.ReadLine();
            string[] commandParams = command.Split(' ').ToArray();

            while (command != "end")
            {
                switch (commandParams[0])
                {
                    case "remove":
                        string type = commandParams[1];
                        string colOrRow = commandParams[2];
                        var position = int.Parse(commandParams[commandParams.Length - 1]);

                        if (colOrRow == "row")
                        {
                           

                            switch (type)
                            {
                                case "positive":
                                   
                                    break;

                                case "negative":
                                    break;

                                case "odd":
                                    break;

                                case "even":
                                    break;
                            }
                        }
                        else
                        {

                        }
                       



                        break;

                    case "swap":
                        var firstRow = int.Parse(commandParams[1]);
                        var secondRow = int.Parse(commandParams[commandParams.Length-1]);

                        // CODE............

                        break;

                    case "insert":
                        var row = int.Parse(commandParams[1]);
                        var element = int.Parse(commandParams[commandParams.Length - 1]);
                        
                        //.........CODE.........


                        break;
                }
            }
               
      }
   }
}

