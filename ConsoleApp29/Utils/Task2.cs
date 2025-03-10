using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task2
    {
        private double a, b, c;

        public Task2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Calculate()
        {
            double average = (a + b + c) / 3;
            Console.WriteLine($"Среднее значение: {average}");
        }
    }
}
