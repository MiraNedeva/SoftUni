using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int count = 0;

            int courses = numberOfPeople / capacity;
           // Console.WriteLine(courses);
            if (numberOfPeople % capacity != 0)
            {
                count++;

            }
            int totalCourses = courses + count;
            Console.WriteLine(totalCourses);
        }
    }
}
