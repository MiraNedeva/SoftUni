using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are given a sequence of strings, each on a new line, unitll you receive “stop” command. First string is a name of a person. On the second line you receive his email. Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk" (case insensitive). Print:
{name} – > {email} */ 

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailsAdresses = new Dictionary<string, string>();

            string commandLine = Console.ReadLine();

             while (!commandLine.Equals ("stop"))
            {

                string email = Console.ReadLine();

                emailsAdresses[commandLine] = email;

                commandLine = Console.ReadLine();
            }
            var FinalEmails = emailsAdresses.Where(a => !a.Value.ToLower().EndsWith("us") && !a.Value.ToLower().EndsWith("uk")).ToDictionary(p => p.Key, p => p.Value);

            foreach (var item in FinalEmails)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }   
        }
    }
}
