using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_20
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("mass: ");
            double A = Double.Parse(Console.ReadLine());
            Console.WriteLine("velocity:");
            double B = Double.Parse(Console.ReadLine());
            Console.WriteLine("height:");
            double C = Double.Parse(Console.ReadLine());
            double result1;
            double result2;

            if (A < 0 )
            {
                Console.Write("Значение mass должно быть положительным ");
                return;
            }

            if (B < 0)
            {
                Console.Write("Значение velocity должно быть положительным ");
                return;
            }


            if (C < 0)
            {
                Console.Write("Значение height должно быть неотрицательным ");
                return;
            }


            result1 = (A * B) + ((C * Math.Pow(B, 2) / 2));

            Console.WriteLine("Результат: {0:F4}", result);










        }
    }
}
