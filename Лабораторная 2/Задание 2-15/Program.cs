using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_15
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите temperatureInC:");
            double A = Double.Parse(Console.ReadLine());
            double result;


            if (A < -273.15)
            {
                Console.Write("Температура должна быть выше абсолютного нуля ");
                return;
            }
            result = A * 1.8 + 32;

            Console.WriteLine("Результат (temperatureInF): {0:F4}", result);










        }
    }
}
