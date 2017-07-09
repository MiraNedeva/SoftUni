using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are given a date in format day-month-year. Calculate and print the day of week in English.*/

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateAsString = Console.ReadLine();
            var date = DateTime.ParseExact(dateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
