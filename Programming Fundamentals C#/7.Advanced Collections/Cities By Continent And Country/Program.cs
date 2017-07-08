using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program to read continents, countries and their cities, put them in a nested dictionary and print them.
Hints:
•	Use a nested dictionary (string  (Dictionary  List<string>)) 
•	Check if the continent exists before adding the country. If it doesn’t, add it to the dictionary.
•	Check if the country exists, before adding the city. If it doesn’t, add it to the dictionary.
•	Pass through all key-value pairs in the dictionary and the values’ key-value pairs and print the results. */

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, Dictionary<string,List<string>>>();
            //reading
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!result.ContainsKey(continent))
                {
                    result[continent] = new Dictionary<string, List<string>>();
                }
                if (!result[continent].ContainsKey(country))
                {
                    result[continent][country] = new List<string>();
                }
                result[continent][country].Add(city);
            }

            //printing
            foreach (var item in result)
            {
                var continent = item.Key;
                var country = item.Value;

                Console.WriteLine($"{continent}:");

                foreach (var kvp in country)
                {
                    var countryName = kvp.Key;
                    var city = kvp.Value;

                    Console.WriteLine($"  {countryName} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}
