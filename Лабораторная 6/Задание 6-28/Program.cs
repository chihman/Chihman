using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_28
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, z, i, n;
            x = 0;
            z = 0;
            i = 0;
            n = 0;
            Console.Write(" Введите число X  ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x < 1)
            { Console.Write("Значение Х должно быть больше 0"); }
            z = 0;
            while (i <= x)
            {
                i = i + 1;
                z = z + 1;
                n = x % z;


                if (n == 0)
                {

                    Console.Write(z + " ");

                }

            }



        }
    }
}
