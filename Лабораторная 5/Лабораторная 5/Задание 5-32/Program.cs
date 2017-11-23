using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные X1: ");
            double X1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите данные Y1: ");
            double Y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите данные H1: ");
            double H1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите данные W1: ");
            double W1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите данные X2: ");
            double X2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите данные Y2: ");
            double Y2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите данные H2: ");
            double H2 = Double.Parse(Console.ReadLine());
            if (H1 < 1 || H2 < 1)
            {
                Console.WriteLine("Высота далжна быть больше 0");
            }
            Console.WriteLine("Введите данные W2: ");
            double W2 = Double.Parse(Console.ReadLine());

            if (X1 + W1 < X2 || Y1 + H1 < Y2 || X2 + W2 < X1 || Y2 + H2 < Y1)
            { Console.WriteLine("Не пересекаются");
                return;
            };

            double X, Y, XX, YY, A, B, HH, XW;
            XW = 0;
            XX = 0;
            HH = 0;
            X = X1 + W1;
            Y = Y1 + H1;
            XX = X2 + W2;
            YY = Y2 + H2;

            if (X1 >= X2 && Y1 >= Y2)
            {               
                A = X1;
                B = Y1;
            }

            else
            {
                A = X2;
                B = Y2;
            }

            if (XX < X)
            { XW = XX - A; }
            else { XW = X - A; }

            if (YY < Y)
            { HH = YY - B; }
            else
            { HH = Y - B; }

            Console.WriteLine("\"x:\" {0:F0},\"y:\" {1:F0},\"w:\"{2:F0},\"h:\"{3:F0}", A, B, XW, HH);

        }
    }
}
