using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Write a program, which reads the name of a student and their grades and adds them to the student record, then prints grades along with their average grade.*/

namespace AverageStudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string,List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var name = input[0];
                var grade = double.Parse(input[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }
            foreach (var item in grades)
            {
                Console.WriteLine("{0} -> {1} (avg: {2:F2})", item.Key, string.Join(" ",item.Value.Select(p => string.Format("{0:f2}",p))),item.Value.Average());
            }
        }
    }
}
