using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You have been tasked to sort out a database full of information about employees. You will be given several input lines containing information in one of the following formats:
•	{name} -> {age}
•	{name} -> {salary}
•	{name} -> {position}
As you see you have 2 parameters. There can be only 3 cases of input:
If the second parameter is an integer, you must store it as name and age.
If the second parameter is a floating-point number, you must store it as name and salary.
If the second parameter is a string, you must store it as name and position.
You must read input lines, then parse and store the information from them, until you receive the command 
“filter base”. When you receive that command, the input sequence of employee information should end.
On the last line of input you will receive a string, which can either be “Age”, “Salary” or “Position”. Depending on the case, you must print all entries which have been stored as name and age, name and salary, or name and position.
In case, the given last line is “Age”, you must print every employee, stored with its age in the following format:
Name: {name1}
Age: {age1}
====================
Name: {name2}
. . .
In case, the given last line is “Salary”, you must print every employee, stored with its salary in the following format:
Name: {name1}
Salary: {salary1}
====================
Name: {name2}
. . .
NOTE: The Salary must be formatted to 2 digits after the decimal point.
In case, the given last line is “Position”, you must print every employee, stored with its position in the following format:
Name: {name1}
Position: {position1}
====================
Name: {name2}
. . .
NOTE: Every entry is separated with the other, with a string of 20 character ‘=’.
There is NO particular order of printing – the data must be printed in order of input.*/

namespace FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var databasePosition = new Dictionary<string, string>();
            var databaseAge = new Dictionary<string, int>();
            var databaseSalary = new Dictionary<string, double>();
            
            while (!input[0].Equals("filter"))
            {
                var name = input[0];
                var number = 0;
                double number2 = 0.0d;

                if (int.TryParse(input[input.Length - 1], out number))
                {
                    var age = input[input.Length - 1];
                    databaseAge[name] = int.Parse(age);
                }
                
                else if (double.TryParse((input[input.Length - 1]), out number2))
                {
                    var salary = input[input.Length - 1];
                    databaseSalary[name] = double.Parse(salary);
                }
                else
                {
                    var position = input[input.Length - 1];
                    databasePosition[name] = position;
                }
                input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            }
            input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            switch (input[0])
                {
                    case "Age":
                        foreach (var item in databaseAge)
                        {
                            Console.WriteLine($"Name: {item.Key}");
                            Console.WriteLine($"Age: {item.Value}");
                            Console.WriteLine("====================");
                        }
                        break;
                    case "Salary":
                        foreach (var item in databaseSalary)
                        {
                            Console.WriteLine($"Name: {item.Key}");
                            Console.WriteLine($"Salary: {item.Value:F2}");
                            Console.WriteLine("====================");
                        }
                        break;
                    case "Position":
                        foreach (var item in databasePosition)
                        {
                            Console.WriteLine($"Name: {item.Key}");
                            Console.WriteLine($"Position: {item.Value}");
                            Console.WriteLine("====================");
                        }
                        break;
                }
       }
    }
 }

 






















