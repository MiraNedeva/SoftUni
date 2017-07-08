using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
