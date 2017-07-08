using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double pricePerBanana = double.Parse(Console.ReadLine());
            double pricePerEgg = double.Parse(Console.ReadLine());
            double pricePerKiloBerries = double.Parse(Console.ReadLine());


            var numberOfSets = Math.Ceiling (guests / 6.0);
            //Console.WriteLine(numberOfSets);
            double neededSumBanana = numberOfSets * (2 * pricePerBanana);
            double neededSumEggs = numberOfSets * (4 * pricePerEgg);
            double neededSumBerries = numberOfSets * (0.2 * pricePerKiloBerries);

            double totalSum = neededSumBanana + neededSumEggs + neededSumBerries;
            // Console.WriteLine(totalSum);
            if (cash >= totalSum)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.",totalSum);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.",totalSum - cash);
            }
        }
    }
}
