using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* LINQ is the greatest .NET component of all time. You can do almost anything with it. That’s why you have been tasked to do almost everything you can with it.
You will be given several input lines containing information about collections, and LINQ methods that have been called on them, in the following format:
{collection}.{method1}().{method2}(). . .
The count of methods, may vary. Your task is to store every collection and the methods that have been executed on them. If the collection already exists, you must ADD the new methods to it. Duplicate methods should be REMOVED.
If you are given a collection name ONLY, you must print the methods that have been executed on the collection, in descending order by their length. If 2 methods have the same length, order them in descending order, by the count of unique symbols they have in their names. The methods must be printed – each on a new line, with an asterisk (“*”) and a space (“ “) prefix.
If the collection name does NOT exist, you should IGNORE that line of input. 
If you are given a digit ONLY, you must take the collection, with the most methods, and print the first N methods, with the LOWEST length (N being the digit given from the input). If there are less than N methods you must print all of them, in the same order.
NOTE: When printing, you must print only the method name, without its brackets.
The input sequence ends when you receive the command “exit”. After the ending command, you will receive one last line in the following format:
{method} {selection}
You must take all collections, which CONTAIN the given method, and print them. The selection will either be “collection” or “all”. 
If you have “collection”, you must print only the collections’ names in the final output.
If you have “all”, you must print the collections and their methods in the following format:
“{collection}
 * {method1}
 * {method2}
 . . .”
The collections, must be printed in descending order, by the count of methods. If 2 collections have the same count, print the one with the higher MINIMAL method length, first. The methods must be printed in descending order by their length.*/

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
 

