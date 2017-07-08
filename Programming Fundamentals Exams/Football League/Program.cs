using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string line = Console.ReadLine();
            // DICTIONARY: TEAM NAME -> GOALS
            var teamGoals = new Dictionary<string, int>();
            // DICTIONARY: TEAM NAME -> POINTS
            var teamPoints = new Dictionary<string, int>();
          
            while (!line.Equals("final"))
            {
                string[] lineArgs = line.Split(' ');

                // DECRYPTAGE HOME TEAM
                string decryptedHomeTeam = lineArgs[0];
                int firstIndex = decryptedHomeTeam.IndexOf(key) + key.Length;
                int lastIndex = decryptedHomeTeam.LastIndexOf(key);
                int lenght = lastIndex - firstIndex;

                string homeTeam = decryptedHomeTeam.Substring(firstIndex, lenght);
                char[] homeTeamArray = homeTeam.ToUpper().ToCharArray();
                Array.Reverse(homeTeamArray);
               homeTeam = new string(homeTeamArray);

                // DECRYPTAGE GUEST TEAM
                string decryptedGuestTeam = lineArgs[1];
                firstIndex = decryptedGuestTeam.IndexOf(key) + key.Length;
                lastIndex = decryptedGuestTeam.LastIndexOf(key);
                lenght = lastIndex - firstIndex;

                string guestTeam = decryptedGuestTeam.Substring(firstIndex, lenght);
                char[] guestTeamArray = guestTeam.ToUpper().ToCharArray();
                Array.Reverse(guestTeamArray);
                guestTeam = new string(guestTeamArray);

                // DECRYPTAGE SCORE OF TWO TEAMS
                var score = lineArgs[lineArgs.Length - 1].Split(':').Select(int.Parse).ToArray();
                var homeTeamScore = score[0];
                var guestTeamScore = score[score.Length - 1];

                var homePoints = 0;
                var guestPoints = 0;

                if (!teamGoals.ContainsKey(homeTeam)) 
                {
                    teamGoals[homeTeam] = 0;

                }
                teamGoals[homeTeam] += homeTeamScore;
               

                if (!teamGoals.ContainsKey(guestTeam))
                {
                    teamGoals[guestTeam] = 0;
                }
                teamGoals[guestTeam] += guestTeamScore;
                // SECOND DICTIONARY
                if (homeTeamScore > guestTeamScore)
                {
                    homePoints += 3;
                    if (!teamPoints.ContainsKey(homeTeam))
                    {
                        teamPoints[homeTeam] = 0;
                    }
                    teamPoints[homeTeam] +=  homePoints;

                    if (!teamPoints.ContainsKey(guestTeam))
                    {
                        teamPoints[guestTeam] = 0;
                    }
                    teamPoints[guestTeam] += guestPoints;
                    
                }
                else if(homeTeamScore < guestTeamScore)
                {
                    guestPoints += 3;

                    if (!teamPoints.ContainsKey(homeTeam))
                    {
                        teamPoints[homeTeam] = 0;
                    }
                    teamPoints[homeTeam] += homePoints;

                    if (!teamPoints.ContainsKey(guestTeam))
                    {
                        teamPoints[guestTeam] = 0;
                    }
                    teamPoints[guestTeam] += guestPoints;
                }
                else if (homeTeamScore == guestTeamScore)
                {
                    homePoints += 1;
                    guestPoints += 1;
                    if (!teamPoints.ContainsKey(homeTeam))
                    {
                        teamPoints[homeTeam] = 0;
                    }
                    teamPoints[homeTeam] += homePoints;

                    if (!teamPoints.ContainsKey(guestTeam))
                    {
                        teamPoints[guestTeam] = 0;
                    }
                    teamPoints[guestTeam] += guestPoints;
                }
                
                line = Console.ReadLine();
            }

            var count = 1;

            Console.WriteLine("League standings:");
            foreach (var item in teamPoints.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine("{0}. {1} {2}",count,item.Key, item.Value);
                count++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in teamGoals.OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine("- {0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
