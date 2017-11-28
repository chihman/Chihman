using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, I, y1000;
            y1000 = 999;
            i = 99;
            I = 0;
            Console.Write(" Посчитать количество чисел, кратных 13, от 100 до 1000.  ");
            while (i <= y1000)
            {
                i = i + 1;
                if (i % 13 == 0)
                {
                    Console.Write(i + "+ ");
                    I = I + 1;
                }
                else
                { Console.Write(i + " "); }

            }
            Console.Write("Ответ: " + I);
        }


    }
}

