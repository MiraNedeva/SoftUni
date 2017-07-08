using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You have been tasked to create a Console Social Media Database.
You will receive several input lines in one of the following formats:
•	post {postName}
•	like {postName}
•	dislike {postName}
•	comment {postName} {commentatorName} {content}
If you receive the post command, you must create a post with the given name.
If you receive the like command you must add a like to the given post.
If you receive the dislike command you must add a dislike to the given post.
If you receive the comment command, you must add a comment to the given post. The comment’s writer must be the given commentator name,
and the content of the comment must be the given content.
By default the posts have 0 likes, 0 dislikes and 0 comments, when created.
When you receive the command “drop the media” you must end the input sequence, and you must print every post with its likes, 
disliked and comments in the following format:
Post: {postName} | Likes: {likes} | Dislikes {dislikes}
Comments:
*  {commentator1}: {comment1}
*  {commentator2}: {comment2}
. . .  
If a certain post does NOT have ANY comments, you should just print “None”.The comments have a prefix of a single asterisk (‘*’) and 2 spaces.
There is NO space between the commentator’s name and the colon.
Constraints
•	The post name will be a string of letters and digits.
•	The commentator’s name will be a string of letters.
•	The comment’s CONTENT, may contain ANY ASCII character.
•	There will be NO invalid input data. */

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
