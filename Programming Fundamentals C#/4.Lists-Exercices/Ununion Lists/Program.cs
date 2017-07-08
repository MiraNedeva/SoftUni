using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You will be given a sequence of integers, separated by a space. This is the primal list. Then you will receive an integer N. 
On the next N lines, you will receive sequences of integers. Your task is to add all elements that the primal list does not contain from
the current sequence to the primal list and then remove from the primal list, all elements which are contained in the current sequence of
integers. If there are several occurrences, remove all occurrences you find.
After you are done receiving lists and manipulating the primal list, sort the primal list and print it.
Exemple: Input	              Output
     1 2 3 4 5                1 14 16 20
     3
     3 4 5 20 1
     16 2 1
     14	*/

namespace UnunionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                var currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < currentList.Count; j++)
                {
                    if (primalList.Contains(currentList[j]))
                    {
                        primalList.Remove(currentList[j]);
                    }
                    else
                    {
                        primalList.Add(currentList[j]);
                    }
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
