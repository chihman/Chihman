using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_23
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("a: ");
            double a = Double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.Write("Данное уравнение не является квадратным ");
                return;
            }



            Console.WriteLine("b: ");
            double b = Double.Parse(Console.ReadLine());
           


            Console.WriteLine("c: ");
            double c = Double.Parse(Console.ReadLine());
                        double result;


            result = b*b-4*a*c;
            
            Console.WriteLine(" discriminant =  {0:F4}", result);
        }
    }
}
