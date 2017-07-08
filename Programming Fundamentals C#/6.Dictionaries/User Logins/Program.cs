using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that receives a list of username-password pairs in the format “{username} -> {password}”. 
If there’s already a user with that username, replace their password. After you receive the command “login”,login requests start coming in, using the same format. Your task is to print the status of user login, using different messages as per the conditions below:
•	If the password matches with the user’s password, print “{username}: logged in successfully”.
•	If the user doesn’t exist, or the password doesn’t match the user, print “{username}: login failed”. 
When you receive the command “end”, print the count of unsuccessful login attempts, using the format “unsuccessful login attempts:{count}”.*/

namespace UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var login = new Dictionary<string, string>();
          
            while (!input[0].Equals("login"))
            {
                var username = input[0];
                var password = input[input.Length - 1];

                if (!login.ContainsKey(username))
                {
                    login[username] = " ";
                }
                login[username] = password;

                input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var count = 0;
            while (!input[0].Equals("end"))
            {
                var username = input[0];
                var password = input[input.Length - 1];
                
                if ((!login.ContainsKey(username)) || (!login.ContainsValue(password)))
                {
                    Console.WriteLine($"{username}: login failed");
                    count++;
                }
                else
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }
                
                input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
