using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are given a sequence of people and for every person what cards he draws from the deck. The input will be separate lines in the format:
{personName}: {PT, PT, PT,… PT}
Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type. The input ends when a "JOKER" is drawn. The name can contain any ASCII symbol except ':'. The input will always be valid and in the format described, there is no need to check it.
A single person cannot have more than one card with the same power and type, if he draws such a card he discards it. The people are playing with multiple decks. Each card has a value that is calculated by the power multiplied by the type. Powers 2 to 10 have the same value and J to A are 11 to 14. Types are mapped to multipliers the following way (S -> 4, H-> 3, D -> 2, C -> 1).
Finally print out the total value each player has in his hand in the format:
{personName}: {value} */

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List <string>> playerCards = new Dictionary<string, List<string>>();

            string commandLine = Console.ReadLine();

            while (! commandLine.Equals("JOKER"))
            {
                string[] commandArgs = commandLine
                    .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                string playerName = commandArgs[0];
                string[] cards = commandArgs[1]
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(c => c.Trim()).ToArray();


                if (! playerCards.ContainsKey(playerName))
                {
                    playerCards.Add(playerName, new List<string>());  // za da zadelim pamet za nov list                     
                }

                playerCards[playerName].AddRange(cards);  // davame karti na vseki chovek
                commandLine = Console.ReadLine();
            }
            PrintPlayerScores(playerCards);
        }

        private static void PrintPlayerScores(Dictionary<string, List<string>> playerCards)
        {
            foreach (var playerEntry in playerCards)
            {
                string playerName = playerEntry.Key;
                List<string> cards = playerEntry.Value.Distinct().ToList();

                int playerScore = 0;
                foreach (var card in cards)
                {
                    string rank = card.Substring(0, card.Length - 1);
                    string suite = card.Substring(card.Length - 1);

                    int rankPower = GetRank(rank);
                    int suitePower = GetSuite(suite);

                    playerScore += rankPower * suitePower;
                }
                Console.WriteLine("{0}: {1}",playerName, playerScore);
            }
        }

        private static int GetRank(string rank)
        {
            switch (rank)
            {
                case "2":
                    return 2; 
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 1;
                   
            }
        }

        private static int GetSuite (string suite)
        {
            switch (suite)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 1;
                    
            }
        }
    }
}
