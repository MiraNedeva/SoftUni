using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElemetsAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();

            List<string> evenElements = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (i % 2 != 0)
                {
                    evenElements.Add(words[i]);
                }
            }
            Console.WriteLine(string.Join("", evenElements));
        }
    }
}
