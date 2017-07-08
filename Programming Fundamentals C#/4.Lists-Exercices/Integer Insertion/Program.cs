using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You will receive a list of integers on the same line (separated by one space). On the next lines, you will start receiving a list of strings, until you receive the string “end”. Your task is to insert each string (converted to integer) at a specific index in the list. The index is determined by the first digit of the number.
Example: 514 -> first digit – 5 -> insert 514 at the 5th index of the list.
After you insert all the elements, print the list, separated by single spaces.
The input will always be valid and you don’t need to explicitly check if you’re inserting an element into a valid index.*/

namespace IntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                var currentNumber = input[0];

                char digits = currentNumber.ToCharArray();

                var firstDigit = digits[0];

                numbers.Insert(currentNumber[firstDigit]);
                input = Console.ReadLine();
            }
        }
    }
}

