using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfFiles = int.Parse(Console.ReadLine());
            // Dictionary : ROOT  -> FILENAMEANDEXT -> SIZE
            var files = new Dictionary<string, Dictionary<string, long>>();
            
            for (int i = 0; i < numberOfFiles; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ', ';', '\\' }, StringSplitOptions.RemoveEmptyEntries);

                string root = input[0];
                string filenameAndExt = input[input.Length - 2];
                long size = long.Parse(input[input.Length - 1]);

                if (!files.ContainsKey(root))
                {
                    files[root] = new Dictionary<string, long>();
                }

                files[root][filenameAndExt] = size;
              
            }
            string[] query = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string queryExtension = query[0];
            string queryRoot = query[query.Length-1];

            if (files.ContainsKey(queryRoot))
            {
                var extractedFiles = files.Where(x => x.Key == queryRoot).ToDictionary(x => x.Key, x => x.Value);
                var count = 0;

                foreach (var item in extractedFiles[queryRoot].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    var fileParams = item.Key.Split('.').ToArray();
                    string filename = fileParams[0];
                    string ext = fileParams[fileParams.Length - 1];

                    if (queryExtension == ext)
                    {
                        Console.WriteLine("{0} - {1} KB", item.Key, item.Value);
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("No");
                }
            }
          /*  else
            {
                Console.WriteLine("No");
            }*/

      }
   }
}
 

