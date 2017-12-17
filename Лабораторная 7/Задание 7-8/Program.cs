using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_8
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            int a, b;
            String c,v;
=======
            int a, b, y;
            String c, x;
>>>>>>> c7f955ac79f9189108b7b69f28feb0c447dfbdfb
            Console.Write("Введите СА ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
<<<<<<< HEAD
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
            if (a+b > 10)
            {
                Console.Write("Сумма значений СА и СВ должна быть меньше длины строки ");
                return;
            }

            string Q = "abcdefwxyz";
            c = Q.Substring(0, a);
            Console.Write(c);
            v = Q.Substring(a+b, 10-(a+b));
            Console.Write(v);
=======
                Console.Write("Значение CA должно быть в интервале [0,длина строки) ");
                return;
            }
            Console.Write("Введите СB ");
            b = Convert.ToInt32(Console.ReadLine());

            if (b < 0 || b > 10)
            {
                Console.Write("Значение Cb должно быть в интервале [0,длина строки) ");
                return;
            }
            if (a + b >= 10) { Console.Write("Сумма значений CA и CB должна быть меньше длины строки ");
                return;
            }
            string Q = "abcdefwxyz";





            y = 10 - (a + b);
            c = Q.Substring(0, a);
            x = Q.Substring(a + b, y);
            Console.Write(c + x);
>>>>>>> c7f955ac79f9189108b7b69f28feb0c447dfbdfb
        }
    }
}
