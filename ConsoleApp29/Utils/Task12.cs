using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task12
    {
        private double a, b, c;

        public Task12(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Calculate()
        {
            double min = Math.Min(a, Math.Min(b, c));
            Console.WriteLine($"Наименьшее число: {min}");
        }
    }
}
