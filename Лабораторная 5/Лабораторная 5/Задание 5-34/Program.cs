using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_34
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите данные W: ");
            double w = Double.Parse(Console.ReadLine());
            if (w<1)
            {
                Console.WriteLine("Значение W должно быть положительным");
                return;
            }

            Console.WriteLine("Введите данные h: ");
            double h = Double.Parse(Console.ReadLine());
            if (h < 1)
            {
                Console.WriteLine("Значение h должно быть положительным");
                return;
            }

            Console.WriteLine("Введите данные C: ");
            double c = Double.Parse(Console.ReadLine());
            if (c < 1)
            {
                Console.WriteLine("Значение C должно быть положительным");
                return;
            }

            Console.WriteLine("Введите данные D: ");
            double d = Double.Parse(Console.ReadLine());
            if (d < 1)
            {
                Console.WriteLine("Значение D должно быть положительным");
                return;
            }
            double X1, X2,Y1,Y2,B, A;
           

            X1 = (int)(h / c);
            X2 = (int)(w / d);
            A = (X1 * X2);

            Y1 = (int)(h / d);
            Y2 = (int)(w / c);
            B = (Y1 * Y2);

            if (A>B)
            {
                
                Console.WriteLine(A+" при С вдоль Н ");
            }

            else
            {
               
                Console.WriteLine(B + " при C вдоль W ");
            }
            
        }
    }
}
