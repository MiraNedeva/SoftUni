using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var mediaPosts = new Dictionary<string, Dictionary<string, List<string>>>();


            while (!input.Equals("drop the media"))
            {
                var inputLine = input.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                var command = inputLine[0];
                var postName = inputLine[1];

                // creation du dictionaire
                if (command == "post")
                {
                    if (!mediaPosts.ContainsKey(postName))
                    {
                        mediaPosts[postName] = new Dictionary<string, List<string>>();
                    }
                    
                }
                

                // remplissage du dictionnaire si la commande est "like"
                else if (command == "like")
                {
                    if (!mediaPosts[postName].ContainsKey(command))
                    {

                        mediaPosts[postName]["like"] = new List<string>();
                    }
                    mediaPosts[postName]["like"].Add(command);

                }
                // remplissage du dictionnaire si la commande est "dislike"
               else if (command == "dislike")
                {
                    if (!mediaPosts[postName].ContainsKey(command))
                    {

                        mediaPosts[postName]["dislike"] = new List<string>();
                    }
                    mediaPosts[postName]["dislike"].Add(command);
                }

                // remplissage du dictionnaire si la commande est "comment"
                else if (command == "comment")
                {

                    var commentatorName = inputLine[2];
                    var continent = inputLine[3];

                    if (!mediaPosts[postName].ContainsKey(commentatorName))
                    {
                        mediaPosts[postName][commentatorName] = new List<string>();
                    }
                    mediaPosts[postName][commentatorName].Add(continent);

                }

                input = Console.ReadLine();
            }


            foreach (var post in mediaPosts)
            {
                var likes = 0;
                var dislikes = 0;
                var writers = post.Value;

              foreach (var item in post.Value)
                {
                    
                    if (item.Key == "like")
                    {
                        likes = item.Value.Count();
                    }
                    else if (item.Key == "dislike")
                    {
                        dislikes = item.Value.Count;
                    }
                }

                Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}", post.Key, likes, dislikes);
                Console.WriteLine("Comments:");


                bool noComment = true;

                foreach (var comment in writers)
                {
                    if ((comment.Key !="like") && (comment.Key !="dislike"))
                    {
                        noComment = false;
                        foreach (var com in comment.Value)
                        {
                            Console.WriteLine("*  {0}: {1}", comment.Key, com);
                        }
                    }
                }
                if (noComment)
                {
                    Console.WriteLine("None");
                }

            }

        }
    }
}
