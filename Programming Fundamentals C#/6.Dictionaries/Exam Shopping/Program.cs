using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            var inventory = new Dictionary<string, int>();

            while (!input[0].Equals("shopping"))
            {
                var product = input[1];
                var quantity = int.Parse(input[2]);

                if (!inventory.ContainsKey(product))
                {
                    inventory[product] = 0;
                }
                inventory[product] += quantity;

                input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            }


            input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

            while (!input[0].Equals("exam")) 
            {
                var product = input[1];
                var quantity = int.Parse(input[2]);

                if (!inventory.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (inventory[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        inventory[product] -= quantity;
                        if (inventory[product] < 0)
                        {
                            inventory[product] = 0;
                        }
                    }
                }
                input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in inventory)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
               
            }
        }
    }
}








            