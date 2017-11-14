using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные Xt: ");
            double Xt = Double.Parse(Console.ReadLine());
            if (Xt < 0)
            {
                Console.WriteLine(" Значение Xt должно быть не отрицательым ");
                return;
            }
            Console.WriteLine("Введите данные Yt: ");
            double Yt = Double.Parse(Console.ReadLine());

            if (Yt < 0)
            {
                Console.WriteLine(" Значение Yt должно быть не отрицательым ");
                return;
            }
            Console.WriteLine("Введите данные Xp1: ");
            double Xp1 = Double.Parse(Console.ReadLine());
            if (Xp1 < 0)
            {
                Console.WriteLine(" Значение Xp1 должно быть не отрицательым ");
                return;
            }
            Console.WriteLine("Введите данные Yp1: ");
            double Yp1 = Double.Parse(Console.ReadLine());

            if (Yp1 < 0)
            {
                Console.WriteLine(" Значение Yp1 должно быть не отрицательым ");
                return;
            }
            Console.WriteLine("Введите данные Xp2: ");
            double Xp2 = Double.Parse(Console.ReadLine());
            if (Xp2 < 0)
            {
                Console.WriteLine(" Значение Xp2 должно быть не отрицательым ");
                return;
            }
            Console.WriteLine("Введите данные Yp2: ");
            double Yp2 = Double.Parse(Console.ReadLine());

            if (Yp2 < 0)
            {
                Console.WriteLine(" Значение Yp2 должно быть не отрицательым ");
                return;
            }
            double A;
            A = (Yp1 - Yp2) * Xt + (Xp2 - Xp1) * Yt + (Xp1 * Yp2 - Xp2 * Yp1);
            
            if (A==0)
            {
                Console.WriteLine(" Точка принадлежит прямой ");
            }
            else { Console.WriteLine("  Точка не принадлежит прямой "); }
        }
    }
}
