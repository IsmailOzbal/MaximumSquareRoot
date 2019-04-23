using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            var data= Squares(1200, 1300);

            foreach (var item in data)
            {
                value = item;
                while (IsInteger(Sqrt(value)))
                {
                    value = (int)Sqrt(value);
                    Console.WriteLine(value);
                }
            }

         
        }

        static bool IsInteger(double d)
        {
            if (d == (int)d) return true;
            else return false;
        }

        static List<int> Squares(int a, int b)
        {
            List<int> squares = new List<int>();

            for (int i = a; i < b; i++)
            {
                if (IsInteger(Sqrt(i)))
                {
                    squares.Add((int)Sqrt(i));
                }
     
            }

            return squares;
        }
        public static double Sqrt(double _d)
        {
            double w = _d, h = 1;

            if (w < 1)
            {
                h = _d;
                w = 1;
            }

            do
            {
                w *= 0.5;
                h += h;
            } while (w > h);

            double x = h + w;
            double x2 = x * x;
            double x4 = x2 * x * x;
            double x6 = x4 * x * x;
            double x8 = x6 * x * x;
            double h2 = h * h;
            double h3 = h2 * h;
            double h4 = h3 * h;
            double w2 = w * w;
            double w3 = w2 * w;
            double w4 = w3 * w;
            double hw = h * w;
            double h2w2 = h2 * w2;
            double a = (256 * h4 * w4 + 1792 * h3 * w3 * x2 + 1120 * h2w2 * x4 + 112 * hw * x6 + x8);
            double b = (16 * h2w2 + 24 * hw * x2 + x4);
            double c = (4 * hw + x2);
            double xcb = x * c * b;
            return (8 * hw * xcb) / a + a / (32 * xcb);
        }
    }
}
