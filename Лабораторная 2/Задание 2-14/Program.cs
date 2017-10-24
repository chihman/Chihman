using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_14
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("Введите A:");
            double A = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите данные B:");
            double B = Double.Parse(Console.ReadLine());
            double result;
            
            if (B > 0)
            {
                Console.Write("Значение B должно быть не положительным ");
                return;
            }
            result = A* Math.Sqrt( -7*B);

            Console.WriteLine("Результат: {0:F4}", result);

        }
    }
}
