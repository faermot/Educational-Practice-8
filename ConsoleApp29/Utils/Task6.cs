using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task6
    {
        private double A, B, C;

        public Task6(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public void Calculate()
        {
            if (A + B + C > 0)
            {
                A *= 2;
                B *= 2;
                C *= 2;
            }
            else
            {
                A = 0;
                B = 0;
                C = 0;
            }

            Console.WriteLine($"A: {A}, B: {B}, C: {C}");
        }
    }
}
