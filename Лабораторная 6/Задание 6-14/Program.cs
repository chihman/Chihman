using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, n, c, z;
            n = 0;
            b = 0;
            c = 0;
            z = 0;
            Console.Write("Введите А ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите B ");
            b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                c = b;
                while (b < a)
                {
                    b = b + 1;
                    c = c * b;

                }
            }
            else
            {
                c = a;
                while (a < b)
                {
                    a = a + 1;
                    c = c * a;

                }
            }
            Console.WriteLine(c);


        }
    }
}
