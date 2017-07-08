using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program, which receives continents, countries and city names and prints them, grouped by continent, country and city,
all in alphabetical order. No duplicates are allowed.
Hints
•	Since everything needs to be sorted and unique, you can use a SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>. That way, since we’re using dictionaries, we won’t have any duplicated continents or countries.
•	By using a SortedSet to store the city names, we ensure we won’t have any repeating cities. Since everything is sorted, the alphabetical order is taken care of. */

namespace GroupContinentsCountriesAndCities
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            //reading

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!result.ContainsKey(continent))
                {
                    result[continent] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!result[continent].ContainsKey(country))
                {
                    result[continent][country] = new SortedSet<string>();
                }
                result[continent][country].Add(city);
            }

            // printing

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
