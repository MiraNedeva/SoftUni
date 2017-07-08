using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoffeeSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] delimiters = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

            //DICTIONARY: PERSON NAME -> COFFEE TYPE
            var coffeeDrinkers = new Dictionary<string, string>();
            //DICTIONARY: COFFEE TYPE -> QUANTITY
            var coffeeTypeQuantity = new Dictionary<string, long>();

            string firstDelimiter = delimiters[0];
            string secondDelimiter = delimiters[1];


            string input = Console.ReadLine();
           
                while (input != "end of info")
              {
                // CASE IF THE INPUT CONTAINS FIRST DELIMITER
                if (input.Contains(delimiters[0]))
                {
                    var index1 = input.IndexOf(delimiters[0]);
                    string personName = input.Substring(0, index1);
                    string coffeeType = input.Substring(index1  + firstDelimiter.Length, input.Length - (personName.Length + firstDelimiter.Length ));

                    if (!coffeeDrinkers.ContainsKey(personName))
                    {
                        coffeeDrinkers[personName] = "";
                    }
                    coffeeDrinkers[personName] = coffeeType;


                }
                // CASE IF THE INPUT CONTAINS SECOND DELIMITER
                else if (input.Contains(delimiters[1]))
                {
                    var index2 = input.IndexOf(delimiters[1]);
                    string coffeeType = input.Substring(0, index2);
                    var quantity = input.Substring(index2  + secondDelimiter.Length, input.Length - (coffeeType.Length + secondDelimiter.Length));

                    if (!coffeeTypeQuantity.ContainsKey(coffeeType))
                    {
                        coffeeTypeQuantity[coffeeType] = 0;
                    }
                    coffeeTypeQuantity[coffeeType] += long.Parse(quantity);
               
                }
                input = Console.ReadLine();
            }
            foreach (var item in coffeeDrinkers)
            {
                if (!coffeeTypeQuantity.ContainsKey(item.Value))
                {
                    coffeeTypeQuantity[item.Value] = 0;
                }
            }

            // LINES ENTERED UNIL RECEVING THE COMMAND END OF WEEK 
            input = Console.ReadLine();

            var personsQuantity = new Dictionary<string, long>();

            while (input != "end of week")
            {
                string[] inputParams = input.Split(' ');
                string name = inputParams[0];
                long quantityOfCoffee = long.Parse(inputParams[1]);

                if (!personsQuantity.ContainsKey(name))
                {
                    personsQuantity[name] = 0;
                }
                personsQuantity[name] += quantityOfCoffee;


                input = Console.ReadLine();
            }

            foreach (var item in personsQuantity)
            {
                var name = item.Key;
                var quantity = item.Value;

                string type = coffeeDrinkers[name];
               
                coffeeTypeQuantity[type] -= quantity;
            }

            List<string> OutOfCoffee = new List<string>();
            List<string> CoffeeLeft = new List<string>();
            List<string> NameAndType = new List<string>();


            foreach (var item in coffeeTypeQuantity.OrderByDescending(x => x.Value))
            {
                if (item.Value == 0)
                {
                    OutOfCoffee.Add("Out of " + item.Key);

                }
                else
                {
                    CoffeeLeft.Add(item.Key + " " + item.Value);
                }

            }
            foreach (var item in coffeeTypeQuantity.OrderBy(x => x.Key))
            {
                if (item.Value > 0)
                {
                    foreach (var entry in coffeeDrinkers.OrderBy(x=>x.Value).ThenByDescending(x=>x.Key))
                    {
                        if (entry.Value == item.Key)
                        {
                            NameAndType.Add(entry.Key + " " + entry.Value);

                        }
                    }
                   
                }
            }   
            
            Console.WriteLine(string.Join("\n", OutOfCoffee.OrderBy(x=>x)));
            Console.WriteLine("Coffee Left: ");
            Console.WriteLine(string.Join("\n", CoffeeLeft));
            Console.WriteLine("For: ");
            Console.WriteLine(string.Join("\n", NameAndType));

            //  Console.WriteLine(string.Join(", ",coffeeDrinkers));
            //Console.WriteLine(string.Join(", ", coffeeTypeQuantity));


        }
    }
}
