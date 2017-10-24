using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_17
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("velocity1:");
            double A = Double.Parse(Console.ReadLine());
            Console.WriteLine("velocity2:");
            double B = Double.Parse(Console.ReadLine());
            Console.WriteLine("distance: ");
            double C = Double.Parse(Console.ReadLine());
            double result;

            if (A < 0 ||B<0)
            {
                Console.Write("Скорость должна быть неотрицательна ");
                return;
            }

            
            result = C/(A+B);

            Console.WriteLine("Результат: {0:F4}", result);





        }
    }
}
