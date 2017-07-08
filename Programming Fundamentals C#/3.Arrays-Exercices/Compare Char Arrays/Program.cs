using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            List<char> chars1 = new List<char>();
            List<char> chars2 = new List<char>();

            for (int i = 0; i < arr1.Length; i++)
            {
                chars1.Add(char.Parse(arr1[i]));
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                chars2.Add(char.Parse(arr1[i]));
            }

            int len = Math.Min(chars1.Count, chars2.Count);

            for (int i = 0; i < len; i++)
            {
                if (chars1[i] > chars2[i])
                {
                    Console.WriteLine(string.Join ("",chars2));
                    Console.WriteLine(string.Join("", chars1));
                    break;
                }
                else if (chars1[i] < chars2[i])
                {
                    Console.WriteLine(string.Join("", chars1));
                    Console.WriteLine(string.Join("", chars2));
                    break;
                }
            }
        }
    }
}

/*
using System;
using System.Linq;
 
class Program
{
    static void Main()
    {
        char[] inputOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] inputTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        //string[] arrays = { string.Join("", inputOne), string.Join("", inputTwo) };
        string[] arrays = { new string(inputOne), new string(inputTwo) };
        Array.Sort(arrays);
        Console.WriteLine(string.Join("\n", arrays));
    }
}
*/
 *
/*
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
class Program
{
    static void Main(string[] args)
    {
        char[] array1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] array2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        int minLen = Math.Min(array1.Length, array2.Length);
        for(int i=0; i<minLen; i++)
        {
            if(array1[i] < array2[i])
            {
                foreach(char ch in array1)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();

                foreach (char ch in array2)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
                return;
            }
            else if(array2[i] < array1[i])
            {
                foreach (char ch in array2)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();

                foreach (char ch in array1)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
                return;
            }
        }

        if(array1.Length < array2.Length)
        {
            Console.WriteLine(new string(array1));
            Console.WriteLine(new string(array2));
        }
        else
        {
            Console.WriteLine(new string(array2));
            Console.WriteLine(new string(array1));
        }
    }
}
}
*/