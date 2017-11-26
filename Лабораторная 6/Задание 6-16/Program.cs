using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double n,i;
            Console.Write("Введите n ");
            n = Convert.ToDouble(Console.ReadLine());
            if (n <= 0)
            { Console.WriteLine("Значение n должно быть > 0");
                return;
            };


            double a, b, c;
            c = 1;
            i = 0;
            b = 0;
            n = n;   
            while (n > i)
            {
                i=i+1;
                c= 1/i;
                b = b + c;
                
            }
            Console.WriteLine("{0:F4}", b);
        }
    }
}
