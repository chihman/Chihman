using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_13
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("X: ");
            double A = Double.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            double B = Double.Parse(Console.ReadLine());
            Console.WriteLine("Z: ");
            double C = Double.Parse(Console.ReadLine());



            if (A==B ||B == C ||C==A)
            {
                Console.WriteLine(" Среди чисел есть равные");
                return;
            }

            else
            {
                Console.WriteLine(" Числа не равны друг другу.");


            }



            








            }
    }
}
