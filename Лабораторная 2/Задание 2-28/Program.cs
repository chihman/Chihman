using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_28
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("a:");
            double a = Double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.Write("Знаменатель не может быть равен нулю ");
                return;
            }

            if (a < 0)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным ");
                return;
            }

            Console.WriteLine("b:");
            double b = Double.Parse(Console.ReadLine());

            if (b == 0)
            {
                Console.Write("Знаменатель не может быть равен нулю ");
                return;
            }

            if (b < 0)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным ");
                return;
            }
            Console.WriteLine("c:");
            double c = Double.Parse(Console.ReadLine());

            if (c == 0)
            {
                Console.Write("Знаменатель не может быть равен нулю ");
                return;
            }

            if (c < 0)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным ");
                return;
            }

            Console.WriteLine("x:");
            double x = Double.Parse(Console.ReadLine());

            if (x == 0)
            {
                Console.Write("Знаменатель не может быть равен нулю ");
                return;
            }

            if (x < 0)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным ");
                return;
            }



            double result1;


            result1 = 1/(Math.Sqrt(a*x*x+b*x+c));


            Console.WriteLine("Результат: {0:F4}", result1);


        }
    }
}
