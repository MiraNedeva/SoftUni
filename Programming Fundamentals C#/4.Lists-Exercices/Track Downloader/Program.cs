using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blacklistedWords = Console.ReadLine().Split(' ').ToList();
            var downloads = new List<string>();

            var files = Console.ReadLine();

            while (files != "end")
            {
                var isInBlacklistedWord = false;

                foreach (var item in blacklistedWords)
                {
                    if (files.Contains(item))
                    {
                         isInBlacklistedWord = true;
                        
                    }
                }
                if (!isInBlacklistedWord)
                {
                    downloads.Add(files);
                }
                    
                

                files = Console.ReadLine();
            }
            downloads.Sort();
            Console.WriteLine(string.Join("\n", downloads));
        }
    }
}
