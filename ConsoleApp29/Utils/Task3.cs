using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task3
    {
        private double x, y, R;

        public Task3(double x, double y, double R)
        {
            this.x = x;
            this.y = y;
            this.R = R;
        }

        public void Calculate()
        {
            double distance = Math.Sqrt(x * x + y * y);
            if (distance < R)
                Console.WriteLine($"Точка ({x}, {y}) лежит внутри окружности.");
            else
                Console.WriteLine($"Точка ({x}, {y}) не лежит внутри окружности.");
        }
    }
}
