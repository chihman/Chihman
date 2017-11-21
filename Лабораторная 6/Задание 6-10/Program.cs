using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, n;
            a = 99;
            b = 0;
            n = 0;
            Console.Write("Ход решения: ");
            while (a < 500)
            {
                a = a + 1;
                b = b + a;
                Console.Write(b + " ");
                n = b;
            }
            Console.Write("Ответ: " + n);

        } }
    }

