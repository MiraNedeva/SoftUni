using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var ladybugsIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var field = new int[size];


            foreach (var item in ladybugsIndexes)
            {
                if (item < 0 || item >= size)
                {
                    continue;
                }
                field[item] = 1;
            }



            // loop for each command
            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                var commandParts = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentLadybugIndex = int.Parse(commandParts[0]);
                var direction = commandParts[1];
                var flyLength = int.Parse(commandParts[commandParts.Length - 1]);

                if (currentLadybugIndex < 0 || currentLadybugIndex >= size)
                {
                    continue;
                }

                if (field[currentLadybugIndex] == 0)
                {
                    continue;
                }
                field[currentLadybugIndex] = 0;
                var position = currentLadybugIndex;


                //loop for each movement of the current ladybug index
                while (true)
                {
                    
                    if (direction == "right")
                    {
                        position += flyLength;
                    }
                    else
                    {
                        position -= flyLength;
                    }
                    if (position < 0 || position >= size)
                    {
                        break;
                    }
                    //there is another ladybug here, keep walking
                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }
            
            }

            Console.WriteLine(string.Join(" ", field));


        }
    }
}
