using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task8
    {
        private double a, b, c;

        public Task8(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Calculate()
        {
            if (a == b || b == c || a == c)
                Console.WriteLine("Треугольник является равнобедренным.");
            else
                Console.WriteLine("Треугольник не является равнобедренным.");
        }
    }
}
