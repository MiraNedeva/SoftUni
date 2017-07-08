using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var populationInfo =  new Dictionary<string, Dictionary<string, double>>();

            string commandLine = Console.ReadLine();
            while (! commandLine.Equals("report"))
            {
                string[] commandLineArgs = commandLine.Split('|');

                string city = commandLineArgs[0];
                string country = commandLineArgs[1];
                var population = double.Parse(commandLineArgs[2]);

                if (! populationInfo.ContainsKey(country))
                {
                    populationInfo.Add(country, new Dictionary<string, double>());
                }
                if (! populationInfo[country].ContainsKey(city))
                {
                    populationInfo[country].Add(city, population);
                }

                commandLine = Console.ReadLine();
            }

            var Orderedcountries = populationInfo.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var country in Orderedcountries)
            {
                var orderedCities = country.Value.OrderByDescending(x => x.Value);

                Console.WriteLine("{0} (total population: {1})",country.Key, country.Value.Sum(x => x.Value));

                foreach (var city in orderedCities)
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
