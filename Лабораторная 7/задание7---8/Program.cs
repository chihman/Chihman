using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание7___8
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            String c, v;

            Console.Write("Введите СА ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {

                Console.Write("Значение CA должно быть в интервале [0,длина строки)");
                return;
            }

            Console.Write("Введите СB ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b < 0)
            {
                Console.Write("Значение Cb должно быть неотрицательно");
                return;
            }
            if (a + b > 10)
            {
                Console.Write("Сумма значений СА и СВ должна быть меньше длины строки ");
                return;
            }


            string Q = "abcdefwxyz";
            c = Q.Substring(0, a);
           
            v = Q.Substring(a + b, 10 - (a + b));
            Console.Write(c + v);

        }

    }
}