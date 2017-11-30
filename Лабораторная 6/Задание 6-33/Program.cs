using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_33
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double w, a, i;
            a = 0;
            i = 0;
           

            Console.Write(" Введите число w  ");
            w = Convert.ToDouble(Console.ReadLine());
            if (w < 0)
            {
                Console.Write("Значение W должно быть >-1 ");
                return;
            }

            a = w - 2;


            Console.Write("+");
            while (a > i)
            {
                i = i + 1;
                Console.Write("-");
            }
            Console.Write("+" + "\n");
            i = 0;

            Console.Write("|");
            while (a > i)
            {
                i = i + 1;
                Console.Write(".");
            }
            Console.Write("|" + "\n");
            i = 0;
            Console.Write("+");
            while (a > i)
            {
                i = i + 1;
                Console.Write("-");
            }
            Console.Write("+" + "\n");
        }
    }
}
