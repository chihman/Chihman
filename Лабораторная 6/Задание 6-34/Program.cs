using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_34
{
    class Program
    {
        static void Main(string[] args)
        {
            double w, a, i, h, x;
            x = 0;
            i = 0;
            Console.Write(" Введите число w  ");
            w = Convert.ToDouble(Console.ReadLine());
            if (w < 0)
            {
                Console.Write("Значение W должно быть >-1 ");
                return;
            }
            Console.Write(" Введите число h  ");
            h = Convert.ToDouble(Console.ReadLine());
            if (h < 0)
            {
                Console.Write("Значение W должно быть >-1 ");
                return;
            }
            if (w == 0 || h == 0)
            { return; }
            Console.Write(" ");
            while (w > i)
            {
                Console.Write(i);
                i = i + 1;

            }
            Console.Write(" \n");
            i = 0;
            a = 0;
            while (h > i)
            {
                Console.Write(i);
                while (a < w)
                {

                    Console.Write(".");
                    a = a + 1;
                }
                a = 0;
                Console.Write("| \n");
                i = i + 1;

            }
            Console.Write(" ");
            while (a < w)
            {

                Console.Write("-");
                a = a + 1;
            }
            a = 0;

        }
    }
}
