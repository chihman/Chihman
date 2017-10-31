using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //ax2 + bx + c = 0
            Console.WriteLine("a: ");
            double a = Double.Parse(Console.ReadLine());


            if (a == 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным ");
                return;
            }


            Console.WriteLine("b: ");
            double b = Double.Parse(Console.ReadLine());

            Console.WriteLine("c: ");
            double c = Double.Parse(Console.ReadLine());

            double D;
            D = b*b-4*a*c;
           




            if (D == 0)
            {
                Console.WriteLine("Вещественных корней уравнения {0:F0}x^2 + {1:F0}x + {2:F0} = 0  один корень", a, b, c);
                return;
            }
            if (D < 0)
            {
                Console.WriteLine("Вещественных корней уравнения {0:F0}x^2 + {1:F0}x + {2:F0} = 0  нет корней", a, b, c  );
                return;
            }
            if (D >0)
            {
                Console.WriteLine("Вещественных корней уравнения {0:F0}x^2 + {1:F0}x + {2:F0} = 0  Два корня", a, b, c);
                return;
            }

        }
    }
}
