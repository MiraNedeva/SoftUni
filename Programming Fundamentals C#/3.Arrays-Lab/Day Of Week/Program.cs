﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Fiday", "Saturday", "Sunday" };
            if ((day >= 1 ) && (day <= 7))
            {
                Console.WriteLine(daysOfWeek[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
            }
            
            
        }
    }
