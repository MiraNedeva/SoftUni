using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are given an array of strings (one line, space-delimited). Sort the array using the Bubble sort or Insertion sort algorithms. 
Instead of comparing if one string is smaller than the other (which you can’t do), you can use the string.CompareTo(str) method. 
Once the array is sorted, print it on the console, separating the elements by spaces.*/ 

namespace SortArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            
            bool swap = false;
            do
            {
                swap = true;

                for (int i = 0; i < words.Length - 1; i++)
                {
                  
                  int result = string.Compare(words[i], words[i+1]);

                    if (result > 0) //str1  after str2
                    {
                        var temp = words[i+1];
                        words[i+1] = words[i];
                        words[i] = temp;
                        swap = false;
                    }
                }
            }
            while (swap == false);
            Console.WriteLine(string.Join(" ",words));
            }
    }
}

