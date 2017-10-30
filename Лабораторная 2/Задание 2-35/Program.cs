using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_35
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("x1:");
            double x1 = Double.Parse(Console.ReadLine());

           

            Console.WriteLine("X2:");
            double x2 = Double.Parse(Console.ReadLine());

            
            
            double result1;


            result1 = Math.Sqrt(Math.Pow(x2,2)+Math.Pow(x1,2));


            Console.WriteLine("Результат: {0:F4}", result1);

        }
    }
}
