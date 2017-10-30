using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_27
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("x:");
            double x = Double.Parse(Console.ReadLine());
            x = x * Math.PI / 180;


            double result1;


            result1 = Math.Sqrt(1 - Math.Pow(Math.Sin(x),2));


                Console.WriteLine("Результат: {0:F4}", result1);

        }
    }
}
