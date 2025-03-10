using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task5
    {
        private int month;

        public Task5(int month)
        {
            this.month = month;
        }

        public void Calculate()
        {
            if (month >= 3 && month <= 5)
                Console.WriteLine("Весна.");
            else if (month >= 6 && month <= 8)
                Console.WriteLine("Лето.");
            else if (month >= 9 && month <= 11)
                Console.WriteLine("Осень.");
            else
                Console.WriteLine("Зима.");
        }
    }
}
