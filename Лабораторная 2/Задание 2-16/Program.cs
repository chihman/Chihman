using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычислить результат по формуле -5x+y

            Console.WriteLine("Введите X:");
            double X = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите данные Y:");
            double Y = Double.Parse(Console.ReadLine());
            
            double result;

            if (Y < 0)
            {
                Console.Write("Значение y должно быть неотрицательным ");
                return;
            }


            double A;
            A = X + Math.Sqrt(Y);

            if (A < 0)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным ");
                    return;
            }

            result = -5*Math.Sqrt(X+ Math.Sqrt(Y));

            Console.WriteLine("Результат: {0:F4}", result);
















        }
    }
}
