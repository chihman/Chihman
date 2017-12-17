using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            String c;
            Console.Write("Введите СА ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.Write("Значение CA должно быть в интервале [0,длина строки)");
                return;
            }
            Console.Write("Введите СB ");
            b = Convert.ToInt32(Console.ReadLine());

            if (b < 0||b>10)
            {
                Console.Write("Значение Cb должно быть в интервале [0,длина строки)");
                return;
            }
            if (b < a)
            {
                Console.Write("Значение CA должно быть меньше CB");
                return;
            }

            b = b - a;
            string Q = "abcdefwxyz";
            c = Q.Substring(a, b + 1);


            Console.Write(c);
        }
    }
}
