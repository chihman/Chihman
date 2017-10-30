using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a: ");
            double a = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("b:");
            double b = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("cInGrad:");
            double grad = Double.Parse(Console.ReadLine());

             double rad;
            double result1;

            rad = grad*Math.PI/180;
            result1 = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2) - 2 * a * b * Math.Cos(rad));

            Console.WriteLine("Результат: {0:F4}", result1);


        }
    }
}
