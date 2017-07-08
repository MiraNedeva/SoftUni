using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var forumTags = new Dictionary<string, List<string>>();

            while (!input.Equals("filter"))
            {
                var inputLine = input.Split(new char[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var topic = inputLine[0];
                

                if (!forumTags.ContainsKey(topic))
                {
                    forumTags[topic] = new List<string>();
                }
                for (int i = 1; i < inputLine.Length; i++)
                {
                    forumTags[topic].Add(inputLine[i]);
                }


                input = Console.ReadLine();
            }
            var line = Console.ReadLine().Split(new char[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();


            foreach (var item in forumTags)
            {
                bool ContainsTag = false;
                var tags = item.Value;
                var count = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    if (tags.Contains(line[i]))
                    {
                        ContainsTag = true;
                        count++;
                    }
                  
                }
                var topic = item.Key;

                if (ContainsTag)
                {
                    if (count > 1)
                    {
                        Console.WriteLine("{0} | #{1}", topic, string.Join(", ", tags));

                    }
                }
            }


            

            // Console.WriteLine("{0}", string.Join(" ", forumTags));
        }
    }
}
