using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_zavd3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x_min = 0, x_max = 7;
            double h = 0.2;
            double x = x_min, y, z;

            Console.WriteLine("x\t\t    y\t\t\t     z");
            Console.WriteLine("_______________________________________________");

            while (x <= x_max)
            {
                y = 1 / Math.Exp(x);
                z = Math.Log10(x / 2 + 0.1);

                Console.WriteLine($"{x,-10:F2}\t{y,-20:F4}\t{z,-20:F4}");
                x += h;
            }
            Console.ReadKey();
        }
    }
}
