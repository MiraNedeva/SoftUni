using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string messagePattern = @"(\d+)\<\-\>([a-zA-Z0-9]+)$";
            string broadcastPattern = @"(\D)\<\-\>([a-zA-Z0-9]+)$";

            Regex messageRegex = new Regex(messagePattern);
            Regex broadcastRegex = new Regex(broadcastPattern);

            string inputLine = Console.ReadLine();

            List<string> messages = new List<string>();
            List<string> broadcast = new List<string>();  

            while (!inputLine.Equals("Hornet is Green"))
            {
                if (messageRegex.IsMatch(inputLine))
                {
                    Match match = messageRegex.Match(inputLine);

                    string recipientCode = string.Join(" ", match.Groups[1].Value.Reverse());

                    string message = match.Groups[2].Value;
                    messages.Add(recipientCode + "->" + message);
                }
                if (broadcastRegex.IsMatch(inputLine))
                {
                    Match match = broadcastRegex.Match(inputLine);

                    string message = match.Groups[1].Value;
                    string frequency = DecriptFrequency(match.Groups[2].Value);
                    broadcast.Add(frequency + "->" + message);
                }
                inputLine = Console.ReadLine();
            }

            
        }

        private static string DecriptFrequency(string value)
        {
            throw new NotImplementedException();
        }
    }
}
