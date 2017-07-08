using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You will receive a list of blacklisted words (on the same line, separated by one space). On the next lines, you will start receiving a
list of filenames (as strings) until you receive the string “end”. Your task is to add the filenames to a list and sort them. Ignore the
tracks which contain the text in the blacklist.*/

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
