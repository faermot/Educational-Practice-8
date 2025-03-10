using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task11
    {
        private double a, b;

        public Task11(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Calculate()
        {
            if (a * b < 0)
            {
                a = -a;
                b = -b;
            }
            else
            {
                a = 0;
                b = 0;
            }

            Console.WriteLine($"A: {a}, B: {b}");
        }
    }
}
