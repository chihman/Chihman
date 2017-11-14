using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные Xt: ");
            double A = Double.Parse(Console.ReadLine());
            if (A < 0)
            {
                Console.WriteLine(" Значение Xt должно быть не отрицательым ");
                return;
            }
            Console.WriteLine("Введите данные Yt: ");
            double B = Double.Parse(Console.ReadLine());
                       
            if (B < 0)
            {
                Console.WriteLine(" Значение Yt должно быть не отрицательым ");
                return;
            }
         
            if ((B<=170&&B>=100)&&(A>=100&&A<=190))
            {
                Console.WriteLine(" Точка внутри ");
            }
            else { Console.WriteLine("  Точка снаружи "); }
        }
    }
}
