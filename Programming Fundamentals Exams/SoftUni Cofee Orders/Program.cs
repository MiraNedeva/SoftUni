using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCofeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfOrders = int.Parse(Console.ReadLine());

           
            decimal total = 0;

            for (int i = 0; i < countOfOrders; i++)
            {
                decimal currentOrderPrice = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

              decimal orderPrice = daysInMonth * capsulesCount * currentOrderPrice;
                total += orderPrice;
                Console.WriteLine("The price for the coffee is: ${0:F2}", orderPrice);
            }
           
            Console.WriteLine("Total: ${0:F2}",total);
        }
    }
}
