using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_25
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, i, I, y;
            y = 0;
            n = 0;
            i = 0;
            I = 0;
            Console.Write(" Введите число Y  ");
            y = Convert.ToDouble(Console.ReadLine());
            if (y < 0 || y > 15)
            { Console.WriteLine(" Значение Y должно быть в интервале  [0-15] ");
                return;
            };
            n = 15 - y;
            while (i <= y)
            {
                i = i + 1;
                Console.Write("#");



            }
            while (I < n)
            {   I = I + 1;
             Console.Write("."); }
        }
    }
}
