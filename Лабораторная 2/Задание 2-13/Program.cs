using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_13
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите данные:");
            double A = Double.Parse(Console.ReadLine());
            double result;
            double B;
            B = 61 - A;
            if (B<0)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным");
                    return;
                    }
            result = 3*Math.Sqrt(61-A);
            
            Console.WriteLine("Результат: {0:F4}", result);
        }
    }
}
