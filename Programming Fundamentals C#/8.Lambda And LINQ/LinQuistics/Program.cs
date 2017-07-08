using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQuistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var collectionDict = new Dictionary<string, HashSet<string>>();
            var result = new List<string>();

            while (inputLine != "exit")
            {
                
                string[] command = inputLine.Split(new char[] { '.', ')', '(' }, StringSplitOptions.RemoveEmptyEntries);
                string collection = command[0];

                if (inputLine.Contains("."))
                {
                   
                    if (!collectionDict.ContainsKey(collection))
                    {
                        collectionDict[collection] = new HashSet<string>();
                    }
                   
                    for (int i = 1; i < command.Length; i++)
                    {
                        if (!collectionDict[collection].Contains(command[i]))
                        {
                            collectionDict[collection].Add(command[i]);
                        }
                }
                }

                else 
                {

                    var number = 0;
               
                    if (int.TryParse(collection, out number))
                    {
                        foreach (var item in collectionDict.OrderByDescending(x => x.Value.Count()))
                        {
                            foreach (var method in item.Value.OrderBy(x => x.Length).Take(number))
                            {
                                result.Add(method);
                            }
                            break;
                        }
                    }
                    else if (inputLine == collection)
                    {
                        if (collectionDict.ContainsKey(collection))
                        {
                            result = collectionDict[collection]
                                  .OrderByDescending(x => x.Length)
                                  .ThenByDescending(x => x.Distinct().Count())
                                  .ToList();
                        }
                    }

                    }
                inputLine = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine("* {0}",item);
            }
            
              string[] commandLine = Console.ReadLine().Split();
              string methods = commandLine[0];
              string selection = commandLine[1];

            if (selection == "all")
            {
                foreach (var item in collectionDict.Where(x =>x.Value.Contains(methods)))
                {
                    Console.WriteLine("{0}",item.Key);
                    foreach (var entry in item.Value.OrderByDescending(x=>x.Length))
                    {
                        Console.WriteLine("* {0}",entry);
                    }

                }
            }
            else 
            {
                foreach (var item in collectionDict.Where(x => x.Value.Contains(methods)).OrderBy(x=>x.Key.Length))
                {
                    Console.WriteLine("{0}", item.Key);
                   
                }
            }


        }
    }
 }
 

