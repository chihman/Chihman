using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Радиус: ");
            double r = Double.Parse(Console.ReadLine());
            if (r < 0)
            {
                Console.WriteLine("Радиус должен быть положительным ");
                return;

            }

            Console.WriteLine("Сторона квадрата: ");
            double x = Double.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Сторона квадрата должна быть положительна");
                return;


            }

            double a;
            a = Math.PI*(r*r);
            double b;
            b = x * x;
            if (a < b)
            {
                Console.WriteLine("Площадь квадрата {0:F4} больше площади круга {1:F4} ", b, a);
                return;
            }
            if (b < a)
            {
                Console.WriteLine(" Площадь круга  {0:F4} больше площади квадрата {1:F4}",a, b);
                return;
            }

            


        }
    }
}
