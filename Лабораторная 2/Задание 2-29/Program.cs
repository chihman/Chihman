using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_29
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("x:");
            double x = Double.Parse(Console.ReadLine());

            if (x <= 0)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным ");
                return;
            }

            

            double result1;


            result1 = ( (Math.Sqrt(x+5))+(Math.Sqrt(x-5)))/(2*Math.Sqrt(x));


            Console.WriteLine("Результат: {0:F4}", result1);



        }
    }
}
