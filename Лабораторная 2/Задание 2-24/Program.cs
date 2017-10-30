using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mass1: ");
            double A = Double.Parse(Console.ReadLine());
            if (A <= 0)
            {
                Console.Write("Значение mass должно быть положительным ");
                return;
            }



            Console.WriteLine("mass2:");
            double B = Double.Parse(Console.ReadLine());
            if (B <= 0)
            {
                Console.Write("Значение mass должно быть положительным ");
                return;
            }




            Console.WriteLine("distance:");
            double C = Double.Parse(Console.ReadLine());

            if (C <= 0)
            {
                Console.Write("Значение distance должно быть неотрицательным ");
                return;
            }




            double result1;
            double result2;

            result1 = 9.8067 * ((A * B) / (Math.Pow(C, 2)));
            

            Console.WriteLine("Результат: {0:F4}", result1);
       




        }
    }
}
