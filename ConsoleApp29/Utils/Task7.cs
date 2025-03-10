using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task7
    {
        private double x1, y1, x2, y2;

        public Task7(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Calculate()
        {
            double distance1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double distance2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (distance1 < distance2)
                Console.WriteLine("Точка A ближе к началу координат.");
            else if (distance1 > distance2)
                Console.WriteLine("Точка B ближе к началу координат.");
            else
                Console.WriteLine("Точки находятся на одинаковом расстоянии.");
        }
    }
}
