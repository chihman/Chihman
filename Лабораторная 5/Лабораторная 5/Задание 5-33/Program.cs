using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_33
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Введите данные t: ");
            double t = Double.Parse(Console.ReadLine());
            if (t < 0 || t > 59)
            {
                Console.WriteLine("Значение T должно быть в интервале [0, 59]");
                return;
            }
            if (t == 0)
            {
                Console.WriteLine("Зеленый");
                return;
            }

            double X;
            X = 0;
            X = t % 10;
            if (X == 1 || X == 2 || X == 5 || X == 6 || X == 7 || X == 8)
            {
                Console.WriteLine("Зеленый");

            }

            else
            {
                Console.WriteLine("Красный");
            }


        }
    }
}
