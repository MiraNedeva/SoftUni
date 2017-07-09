using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* JSON is a syntax for storing and exchanging data. It comes from JavaScript Object Notation. You have been tasked to 
create a database of students, and stored them in a JSON format.
First, create a class Student, which will represent our data model – it will hold our data. The Student should have Name 
(string), Age (integer), and Grades (Collection of integer numbers).
This will be enough to store our data. We’ll need a collection of Students, since we will store a lot of students.
And now let’s see the input and output formats.
The input will consist of several input lines in the following format:
{name} : {age} -> {grade1}, {grade2}, {grade3}. . .
Store every student with its name, age and given grades. The name will be a string which can contain any ASCII characters 
except space (“ “), “:”, “-”, “>”, “,”. The age will be an integer. The grades will be integer numbers.
When you receive the command “stringify”, the input sequence ends.
You should print the collection of students in the following format: [{student1},{student2}. . .]
Each student must be printed in the following format: 
{name:”{name}”,age:{age},grades:[{grade1}, {grade2}. . .]} */

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
