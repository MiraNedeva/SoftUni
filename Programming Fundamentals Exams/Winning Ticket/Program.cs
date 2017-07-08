using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

           // var symbols = "@, #, $, ^"; // ARRAY OF WINNING SYMBOLS
            var countLeft = 0;
            var countRight= 0;

            foreach (var item in tickets)
            {

                if (item.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var half = item.Length / 2;
                    string firstHalf = item.Substring(0, half);
                    string secondHalf = item.Substring(half, item.Length - half);

                    var sym = new List<char>();

                    for (int i = 0; i < firstHalf.Length; i++)
                    {
                        if ((firstHalf[i] == '@') || (firstHalf[i] == '#') || (firstHalf[i] == '$') || (firstHalf[i] == '^'))
                        {
                            countLeft++;
                        }

                    }

                    for (int i = 0; i < secondHalf.Length; i++)
                    {
                        if ((secondHalf[i] == '@') || (secondHalf[i] == '#') || (secondHalf[i] == '$') || (secondHalf[i] == '^'))
                        {
                            countRight++;
                            sym.Add(secondHalf[i]);
                          
                        }
                    }
                    
                  
                    if ((countLeft >= 6) && (countLeft <= 9) && (countRight >= 6) && (countRight <= 9))
                    {
                        char finalSym = sym.First();
                        Console.WriteLine($"ticket \"{item}\" - {countLeft}{finalSym}");
                    }
                    else if ((countLeft == 10) && (countRight == 10))
                    {
                        char finalSym = sym.First();
                        Console.WriteLine($"ticket \"{item}\" - {countLeft}{finalSym} Jackpot!");
                    }
                    else if (((countLeft == 0) || (countLeft < 6)) && ((countRight == 0) || (countRight < 6)))
                    {
                        Console.WriteLine($"ticket \"{item}\" - no match");
                    }
                    
                }
                countLeft = 0;
                countRight = 0;
            }
                
       }
            
    }
 }

