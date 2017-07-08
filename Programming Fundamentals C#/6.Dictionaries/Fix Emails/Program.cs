using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailsAdresses = new Dictionary<string, string>();

            string commandLine = Console.ReadLine();

            /* while (! commandLine.Equals ("stop"))
             {
                 string email = Console.ReadLine();
                 string ending = email.Substring(email.Length -2).ToLower(); 

                 if (! ending.Equals("us") && ! ending.Equals("uk"))
                 {
                     emailsAdresses.Add(commandLine, email);
                 }

                 commandLine = Console.ReadLine();

             }
             foreach (var item in emailsAdresses)
             {
                 Console.WriteLine("{0} -> {1}",item.Key, item.Value);
             }*/

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
