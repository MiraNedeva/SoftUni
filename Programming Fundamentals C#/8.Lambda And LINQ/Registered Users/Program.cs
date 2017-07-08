using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var database = new Dictionary<string, DateTime>();
            
            while (input != "end")
            {
                string[] inputLine = input.Split(new char[] {'-','>',' ' }, StringSplitOptions.RemoveEmptyEntries);
                string username = inputLine[0];
                DateTime registryDate = DateTime.ParseExact(inputLine[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                
                  database[username] = registryDate;
                

                input = Console.ReadLine();
            }

            Dictionary<string, DateTime> orderedUsernames = database
                 .Reverse()
                 .OrderBy(x=>x.Value)
                 .Take(5)
                 .OrderByDescending(x => x.Value)
                 .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in orderedUsernames)
            {
                Console.WriteLine($"{entry.Key}");
            }


           
        }
    }
}
