using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("А: ");
            double X = Double.Parse(Console.ReadLine());
            if (X < 0)
            {
                Console.WriteLine("А должно быть не отрицательным");
                return;
            }

            Console.WriteLine("В: ");
            double Y = Double.Parse(Console.ReadLine());
            if (Y < 0)
            {
                Console.WriteLine("B должно быть не отрицательным");
                return;
            }
            Console.WriteLine("С: ");
            double Z = Double.Parse(Console.ReadLine());
            if (Z < 0)
            {
                Console.WriteLine("C должно быть не отрицательным");
                return;
            }


            if (X == Y || Y == Z || Z == X)
            {

                Console.WriteLine("Треугольник является равнобедренным.");
            }
            else
            {
                Console.WriteLine("Треугольник не является равнобедренным.");
            }
        }
    }
}