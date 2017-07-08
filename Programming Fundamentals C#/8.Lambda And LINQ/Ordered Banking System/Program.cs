using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You have been given the task to write software for banking – in particular, an optimized program, which stores only the bank account’s name, the bank account’s balance and the bank it is stored at.
You will be given several input lines in the following format:
{bank} -> {account} -> {balance}
The bank and the account are strings, and the balance is a VARIABLE TYPE which is SUITABLE for storing MONEY.
You should store every bank, each of its accounts, and their balances. 
If you are given a bank which already exists, you must ADD the new account to it.
If EVEN the account which already exists, you must INCREASE the old balance, with the new given one.
When you receive the command “end”, you must end the input sequence. Then you must print the data in a specified ordered format.
You must print each bank’s accounts and balances, ordering the BANKS by the sum of all account balances, in descending order. If 2 banks have the same sum, you should print the one with the highest maximum balance in its accounts, first. 
The bank’s accounts must be ordered in descending order, by their balance.
The balances, must be printed, as they are given. “500” = “500” … “500.00” = “500.00”.
*/ 

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
