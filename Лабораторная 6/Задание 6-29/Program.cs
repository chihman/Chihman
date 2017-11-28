using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_29
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, i, n;
            x = 0;
            y = 0;
            n = 1;
            Console.Write(" Введите число Y  ");
            y = Convert.ToDouble(Console.ReadLine());

            if (y < 1)
            { Console.Write("Значение Y должно быть больше 0");
                return;
            }

            x = y;
            while (x > 1)
            {
                if (n == 0)
                {
                    Console.Write(" число не простое ");
                    return;
                }
                x = x - 1;

                n = y % x;
                
            }
            Console.Write(" число простое");
        }
    }
}
