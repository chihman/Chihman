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
                        if (A < 0)
            {
                Console.Write("Значение mass должно быть положительным ");
                return;
            }



            Console.WriteLine("velocity:");
            double B = Double.Parse(Console.ReadLine());
            if (B < 0)
            {
                Console.Write("Значение velocity должно быть положительным ");
                return;
            }
                       



            Console.WriteLine("height:");
            double C = Double.Parse(Console.ReadLine());

            if (C < 0)
            {
                Console.Write("Значение height должно быть неотрицательным ");
                return;
            }




            double result1;
            double result2;

            result1 = (A * Math.Pow(B, 2)) / 2;
            result2 = A * 9.8067 * C;

            Console.WriteLine("Кинетическая энергия составляет: {0:F4}", result1);
            Console.WriteLine("Потенциальная энергия составляет: {0:F4}", result2);










        }
    }
}
