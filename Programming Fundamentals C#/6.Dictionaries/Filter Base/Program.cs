using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

 






















