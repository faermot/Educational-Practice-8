using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task9
    {
        private double cost, discount, weekdayMinutes, weekendMinutes;

        public Task9(double cost, double discount, double weekdayMinutes, double weekendMinutes)
        {
            this.cost = cost;
            this.discount = discount;
            this.weekdayMinutes = weekdayMinutes;
            this.weekendMinutes = weekendMinutes;
        }

        public void Calculate()
        {
            double total = weekdayMinutes * cost + weekendMinutes * cost * (1 - discount);
            Console.WriteLine($"Стоимость: {total}");
        }
    }
}
