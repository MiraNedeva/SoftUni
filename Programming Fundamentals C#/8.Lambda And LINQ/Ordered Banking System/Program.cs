using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            var bankingSystem = new Dictionary<string, Dictionary<string, decimal>>();

            while (input != "end")
            {
                string[] command = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string bank = command[0];
                string account = command[1];
                decimal balance = decimal.Parse(command[2]);

                if (!bankingSystem.ContainsKey(bank))
                {
                    bankingSystem[bank] = new Dictionary<string, decimal>();
                }
                if (!bankingSystem[bank].ContainsKey(account))
                {
                    bankingSystem[bank].Add(account, 0);
                }
                bankingSystem[bank][account] += balance;
              
                input = Console.ReadLine();
            }
            // Dictionary<string,Dictionary<string,decimal>> orderedBankingSystem = bankingSystem;

           
                 

            foreach (var item in bankingSystem.OrderByDescending(bank => bank.Value.Sum(accounts => accounts.Value))
                 .ThenByDescending(bank => bank.Value.Max(account => account.Value)))
                 
            {
                foreach (var entry in item.Value.OrderByDescending(account =>account.Value))
                {
                    var bankAccount = entry.Key;
                    var bankBalance = entry.Value;

                    Console.WriteLine("{0} -> {1} ({2})",bankAccount, bankBalance, item.Key);
                }
               
                
            }
           

          
        }
    }
}
