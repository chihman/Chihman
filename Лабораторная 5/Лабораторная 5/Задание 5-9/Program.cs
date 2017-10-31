using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sc: ");
            double Sc = Double.Parse(Console.ReadLine());


            if (Sc < 0)
            {
                Console.WriteLine("Площадь круга должна быть положительной ");
                return;
            }


            Console.WriteLine("Ss: ");
            double Ss = Double.Parse(Console.ReadLine());

            if (Ss < 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положительной ");
                return;
            }


            Console.WriteLine("c: ");
            double c = Double.Parse(Console.ReadLine());

            double D;
            D = b * b - 4 * a * c;





            if (D == 0)
            {
                Console.WriteLine("Вещественных корней уравнения {0:F0}x^2 + {1:F0}x + {2:F0} = 0  один корень", a, b, c);
                return;
            }
            if (D < 0)
            {
                Console.WriteLine("Вещественных корней уравнения {0:F0}x^2 + {1:F0}x + {2:F0} = 0  нет корней", a, b, c);
                return;
            }
            if (D > 0)
            {
                Console.WriteLine("Вещественных корней уравнения {0:F0}x^2 + {1:F0}x + {2:F0} = 0  Два корня", a, b, c);
                return;
            }
    }
}
