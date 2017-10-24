using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_18
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("X1: ");
            double A = Double.Parse(Console.ReadLine());
            Console.WriteLine("X2: ");
            double B = Double.Parse(Console.ReadLine());
            Console.WriteLine("X3: ");
            double C = Double.Parse(Console.ReadLine());
            double result;

                 result = A*B+A*C+B*C;

            Console.WriteLine("Результат: {0:F0}", result);
        }
    }
}
