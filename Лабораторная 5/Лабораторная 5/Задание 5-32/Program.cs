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

            Console.WriteLine("Введите данные W2: ");
            double W2 = Double.Parse(Console.ReadLine());
            double X, Y, XX, YY, A, B, W3, Y3;
            X = X1 + W1;
            Y = Y1 + H1;
            XX = X2 + W2;
            YY = Y2 + H2;

            //ширина
            X = X1 + W1;
            XX = X2 + W2;

            if (XX <= X)
            {
                W3 = XX;
            }
            else { W3 = X; }

            if (X1 >= X2 || Y1 >= Y2)
            {
                //ПЕРВАЯ ЛЕВАЯ ТОЧКА
                A = X1;
                B = Y1;
                W3 = X2;

            }
            else
            { A = X2;
                B = Y2;
            }

           

            

            //высота
            Y = Y1 + H1;
            YY = Y2 + H2;

            if (YY <= Y)
            { Y3 = YY; }
            else { Y3 = Y; }


            Console.WriteLine("\"x:\" {0:F0},\"y:\" {1:F0},\"w:\"{2:F0},\"h:\"{3:F0}", A, B, W3, Y3);

        
    
        }
    }
}
