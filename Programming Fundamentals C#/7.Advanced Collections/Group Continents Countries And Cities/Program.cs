using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
