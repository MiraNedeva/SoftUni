using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You will be given two integer lists on the first two lines (space-separated). Remove the elements in the first list from the elements 
in the second list. If an element from the first list occurs more than once in the second list, remove all occurrences.
After you remove the elements, check the sum of both lists. If the sum of both of them is equal, print “Yes. Sum: {sum}”. 
If not print the absolute difference between the two lists in the format “No. Diff: {sum}”.*/

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var item in firstList)
            {
                if (secondList.Contains(item))
                {
                    secondList.Remove(item);
                }
            }
            var sumFirstList = SumTheListItems(firstList);
            var sumSecondList = SumTheListItems(secondList);

            if (sumFirstList == sumSecondList)
            {
                Console.WriteLine($"Yes. Sum: {sumFirstList}");
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sumFirstList - sumSecondList));
            }
        }

        private static int SumTheListItems(List<int>firstList)
        {
            int sum = 0;
            for (int i = 0; i < firstList.Count; i++)
            {
                sum += firstList[i];
            }
            return sum;
        }
    }
}
