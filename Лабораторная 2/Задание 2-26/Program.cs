using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_26
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("a:");
            double a = Double.Parse(Console.ReadLine());

            if (a <= 0)
            {
                Console.Write("Значение a должно быть не равно нулю ");
                return;
            }

            Console.WriteLine("b:");
            double b = Double.Parse(Console.ReadLine());

            if (b <= 0)
            {
                Console.Write("Значение b должно быть не равно нулю ");
                return;
            }


            Console.WriteLine("c:");
            double c = Double.Parse(Console.ReadLine());

            if (c <= 0)
            {
                Console.Write("Значение c должно быть не равно нулю ");
                return;
            }

            Console.WriteLine("d:");
            double d = Double.Parse(Console.ReadLine());

            if (d <= 0)
            {
                Console.Write("Значение d должно быть не равно нулю ");
                return;
            }
            
            double result1;


            result1 = (a * d + b * c) / (a * d);


            Console.WriteLine("Результат: {0:F4}", result1);
        }
    }
}
