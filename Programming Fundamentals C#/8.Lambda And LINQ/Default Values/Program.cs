using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Dictionary<string,string> dict = new Dictionary<string, string>();

            while (input != "end")
            {
                var commandLine = input.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var key = commandLine[0];
                var value = commandLine[1];

                dict[key] = value;
                
                input = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            Dictionary<string, string> unchangedValues = dict
               .Where(x => x.Value != "null")
               .OrderByDescending(x=> x.Value.Length)
               .ToDictionary(x=> x.Key, x=>x.Value);


            Dictionary<string, string> changedValues = dict
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var item in unchangedValues)
            {
                Console.WriteLine("{0} <-> {1}",item.Key, item.Value);
            }
            foreach (var entry in changedValues)
            {
                Console.WriteLine("{0} <-> {1}", entry.Key, entry.Value);

            }


              //Console.WriteLine(string.Join("\n",unchangedValues));
            //   Console.WriteLine(string.Join("\n", changedValues));
        }
    }
}
