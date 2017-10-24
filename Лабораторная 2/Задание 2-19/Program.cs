using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_19
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("initialVelocity: ");
            double A = Double.Parse(Console.ReadLine());
            Console.WriteLine("time:");
            double B = Double.Parse(Console.ReadLine());
            Console.WriteLine("acceleration:");
            double C = Double.Parse(Console.ReadLine());
            double result;

            if (A <= 0 || B <= 0)
            {
                Console.Write("Начальная скорость и Время должно быть неотрицательна ");
                return;
            }

            result = (A * B) + ((C * Math.Pow(B, 2)/2));

            Console.WriteLine("Результат: {0:F4}", result);


        }
    }
}
