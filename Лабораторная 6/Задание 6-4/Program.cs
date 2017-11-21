using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (b < a)
            {
                Console.Write("значение А и В вводится В>=A ");
                return;
            }
            else
            {
                while (a <= b)
                {
                    Console.WriteLine(b);

                    b = b - 1;
                }

            }
        }
    }
}
