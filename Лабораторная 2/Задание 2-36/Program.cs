using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_36
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Xa:");
            double Xa = Double.Parse(Console.ReadLine());

            

            Console.WriteLine("Ya:");
            double Ya = Double.Parse(Console.ReadLine());

            
            Console.WriteLine("Xb:");
            double Xb = Double.Parse(Console.ReadLine());

           

            Console.WriteLine("Yb:");
            double Yb = Double.Parse(Console.ReadLine());

           


            double result1;


            result1 = Math.Sqrt(Math.Pow((Xb-Xa),2)+Math.Pow((Yb-Ya),2));


            Console.WriteLine("Результат: {0:F4}", result1);









        }
    }
}
