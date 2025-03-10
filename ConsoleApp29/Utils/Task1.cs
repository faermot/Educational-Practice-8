using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task1
    {
        public double X { get; }
        public double Y { get; }

        public Task1(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Calculate()
        {
            if (Y <= 2 - X * X && Y >= 0)
                Console.WriteLine($"Точка ({X}, {Y}) лежит в области.");
            else
                Console.WriteLine($"Точка ({X}, {Y}) не лежит в области.");
        }
    }
}
