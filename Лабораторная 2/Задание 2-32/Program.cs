using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_32
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("a:");
            double a = Double.Parse(Console.ReadLine());


            Double b;
            b = 12 * Math.Pow(a, 2) +7*a - 16;

            Console.WriteLine("Результат: {0:F4}", b);


        }
    }
}
