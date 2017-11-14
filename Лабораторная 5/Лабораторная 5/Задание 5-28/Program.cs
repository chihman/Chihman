using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные A: ");
            double A = Double.Parse(Console.ReadLine());
            if (A < 0)
            {
                Console.WriteLine(" Значение A должно быть не отрицательым ");
                return;
            }
            Console.WriteLine("Введите данные B: ");
            double B = Double.Parse(Console.ReadLine());
            if (B < 0)
            {
                Console.WriteLine(" Значение B должно быть не отрицательым ");
                return;
            }
            Console.WriteLine("Введите данные C: ");
            double C = Double.Parse(Console.ReadLine());
            if (C < 0)
            {
                Console.WriteLine(" Значение C должно быть не отрицательым ");
                return;
            }
            Console.WriteLine("Введите данные D: ");
            double D = Double.Parse(Console.ReadLine());
            if (D < 0)
            {
                Console.WriteLine(" Значение D должно быть не отрицательым ");
                return;
            }
            double Q, W;
            Q = A * B;
            W = C * D;

            if (Q <= W)
            {
                Console.WriteLine(" Размещение возможно ");
            }
            else { Console.WriteLine(" Размещение не возможно "); }


        }
    }
}
