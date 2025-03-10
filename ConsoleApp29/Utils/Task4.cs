using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task4
    {
        private double a, b, c;

        public Task4(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Calculate()
        {
            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                Console.WriteLine("Треугольник является прямоугольным.");
            else
                Console.WriteLine("Треугольник не является прямоугольным.");
        }
    }
}
