using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());

           int position = 0;
            bool deadByBomb = false;

            while (energy > 0)
            {
                deadByBomb = false;

                string[] currentCommand = commands[0].Split('|');
                string action = currentCommand[0];
                int value = int.Parse(currentCommand[1]);

                if (action == "Rabit Hole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }

                

                switch (action)
                {
                    case "Left":
                        position = commands[position] - value;

                        energy -= value;
                        break;
                    case "Right":
                    
                        break;
                    case "Bomb":

                        break;

                }
            }

        }
    }
}
