using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
