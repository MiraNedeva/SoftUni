using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONStringify
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set;}

        public int[] Grades { get; set;}

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string inputLine = Console.ReadLine();

            while (inputLine != "stringify")
            {
                string[] inputParams = inputLine.Split(new char[] { ' ', ':', ',', '>', '-' },StringSplitOptions.RemoveEmptyEntries);

                string studentName = inputParams[0];
                int studentAge = int.Parse(inputParams[1]);
                int[] studentGrades = inputParams.Skip(2).Select(int.Parse).ToArray();

                Student newStudent = new Student();

                newStudent.Name = studentName;
                newStudent.Age = studentAge;
                newStudent.Grades = studentGrades;

                students.Add(newStudent);
                
                inputLine = Console.ReadLine();
            }

            string output = " ";

            output += "[";

            for (int i = 0; i < students.Count; i++)
            {
                Student currentStudent = students[i];

                output += "{";
                output += "name:\"" + currentStudent.Name + "\""+ ",";
                output += "age:" + currentStudent.Age + ",";
                output += "grades:[" + string.Join(", ", currentStudent.Grades)+ "]";
                output += "}"+ ",";
            }
            output += "]";

            Console.WriteLine(output);
        }
    }
}
