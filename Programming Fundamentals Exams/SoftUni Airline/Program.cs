using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniAirline
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfFligths = int.Parse(Console.ReadLine());
            decimal profit = 0;
            decimal expenses = 0;
            decimal income = 0;

            decimal overallProfit = 0;
            decimal averageProfit = 0;

            for (int i = 0; i < numberOfFligths; i++)
            {
                int adultPassengers = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youthPassengers = int.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                int fligthDuration = int.Parse(Console.ReadLine());

                income = ((adultPassengers * adultTicketPrice) + (youthPassengers * youthTicketPrice));
                //Console.WriteLine(income);

                expenses = (fligthDuration * fuelConsumptionPerHour * fuelPricePerHour);
                //Console.WriteLine(expenses);
                profit = income - expenses;
                //Console.WriteLine(profit);

                if (income >= expenses)
                {
                    Console.WriteLine("You are ahead with {0:F3}$.", profit);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:F3}$.", profit);
                }
                overallProfit += profit;
                averageProfit = (overallProfit / numberOfFligths);
            }


            Console.WriteLine("Overall profit -> {0:F3}$.", overallProfit);
            Console.WriteLine("Average profit -> {0:F3}$.", averageProfit);
        }
    }
}
