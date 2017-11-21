using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.Write("Введите А ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите B ");
            b = Convert.ToDouble(Console.ReadLine());
            if (a < b)
            {
                while (a <= b)
                {
                    Console.Write(a + " ");
                    a = a + 1;

                }

            }
            else
            {

                while (a >= b)
                {
                    Console.Write(a + " ");

                    a = a - 1;
                }
            }
        }
    }
}
