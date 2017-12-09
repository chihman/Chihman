using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_37
{
    class Program
    {
        static void Main(string[] args)
        {

            double W, H, a, D, i, Q, j;
            W = 0;
            H = 0;
            a = 0;
            i = 0;
            D = 0;
            Q = 0;
            j = 0;
            Console.Write(" Введите число W  ");
            W = Convert.ToDouble(Console.ReadLine());
            if (W < 0)
            {
                Console.Write("Значение W должно быть >-1 ");
                return;
            }
            Console.Write(" Введите число H  ");
            H = Convert.ToDouble(Console.ReadLine());
            if (H < 0)
            {
                Console.Write("Значение H должно быть >-1 ");
                return;
            }
            if (W==0 || H==0)
            { return; }

            j = W;
            while (W > 0 || H > 0)
            {

                while (a < W )
                {
                    Console.Write("+");
                    a = a + 1;

                }


                Q = j - W;
                while (Q > i)
                {
                    if (i <j)
                    {
                        Console.Write("#");
                    }
                    i = i + 1;
                }

                i = 0;
                a = 0;


                Console.Write("\n");
                W = W - 1;
                H = H - 1;

            }

        }
    }
}
