using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, i, c;
            c = 0;
            n = 0;
            i = 0;

            while (n  <= 1000)
            {
                Console.Write("Введите число  ");
                n = Convert.ToDouble(Console.ReadLine());
                i = i + 1;
                c = c + n;
                n = c;
                
            }
            Console.WriteLine(" количество суммированных чисел: " + i );


        }
    }
}
