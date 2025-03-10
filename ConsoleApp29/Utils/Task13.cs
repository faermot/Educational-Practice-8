using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task13
    {
        private double x, y, z;

        public Task13(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Calculate()
        {
            double average = (x + y + z) / 3;
            if (Math.Abs(x) > average) Console.WriteLine(x);
            if (Math.Abs(y) > average) Console.WriteLine(y);
            if (Math.Abs(z) > average) Console.WriteLine(z);
        }
    }
}