using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычислить результат по формуле 5cos(yInRad). Значение угла дано в градусах.


            Console.WriteLine("Введите данные:");
            double A = Double.Parse(Console.ReadLine());
            double result;
            result = A * Math.PI / 180;
            result =5* Math.Cos(result);
            Console.WriteLine("Результат: {0:F4}", result);



        }
    }
}
