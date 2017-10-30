using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_33
{
    class Program
    {
        static void Main(string[] args)
        {
            //AC = sqrt(h * (2 * R + h))
            // Считая, что Земля -идеальная сфера с радиусом radius = 6350 км,
            //определить расстояние до линии горизонта от точки с заданной высотой 
            //над Землей.

            Console.WriteLine("H:");
            double h = Double.Parse(Console.ReadLine());
            if (h < 0)
                {
                Console.WriteLine("Высота над уровнем Земли должна быть неотрицательна");
                return;

            }

            Double b;
            b = Math.Sqrt(h*(2*6350+h));

            Console.WriteLine("Результат: {0:F4}", b);

        }
    }
}
