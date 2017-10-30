using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2__21
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("R1: ");
            double A = Double.Parse(Console.ReadLine());
           


            if (A == 0)
            {
                Console.Write("Значение r1 должно быть не равно нулю ");
                return;
            }



            Console.WriteLine("R2:");
            double B = Double.Parse(Console.ReadLine());
            if (B == 0)
            {
                Console.Write("Значение r2 должно быть не равно нулю ");
                return;
            }


            

            double result;


            result = (1 / A) + (1 / B);

            Console.WriteLine("Кинетическая энергия составляет: {0:F4}", result);
          







        }
    }
}
