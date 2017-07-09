using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* A master number is an integer that holds the following properties:
•	Is symmetric (palindrome), e.g. 5, 77, 282, 14341, 9553559.
•	Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
•	Holds at least one even digit, e.g. 232, 707, 6886, 87578.
Write a program to print all master numbers in the range [1…n]. */
namespace _23.MasterNumbers
{
    class MasterNumbers
    {
        static bool IsPalindrome(int num)
        {
            string digits = "" + num;
            for (int i = 0; i < digits.Length / 2; i++)
                if (digits[i] != digits[digits.Length - i - 1])
                {
                    return false;
                }
            return true;
        }

        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }

        static bool ContainsEvenDigit(int num)
        {
            string digits = "" + num;
            for (int i = 0; i < digits.Length; i++)
            {
                int digit = digits[i] - '0';
                if (digit % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
                if (IsPalindrome(num) &&
                (SumOfDigits(num) % 7 == 0) && ContainsEvenDigit(num))
                {
                    Console.WriteLine(num);
                }
        }
    }
}