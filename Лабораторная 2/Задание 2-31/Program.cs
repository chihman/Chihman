using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_31
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("x:");
            double x = Double.Parse(Console.ReadLine());


            Double y;
            y = 7*Math.Pow(x,2)-3*x+6;
           
                        Console.WriteLine("Результат: {0:F4}", y);


        }
    }
}
