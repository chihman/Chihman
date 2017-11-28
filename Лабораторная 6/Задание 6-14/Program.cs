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
            int a, b, n,  z;
            long c;
            n = 0;
            b = 0;
            c = 0;
            z = 0;
            Console.Write("Введите А ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B ");
            b = Convert.ToInt32(Console.ReadLine());
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
