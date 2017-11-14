using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            //Выведите на экран число А с окончанием. (значение -10<=А<=100).
            Console.WriteLine("Введите данные A: ");
            double A = Double.Parse(Console.ReadLine());
            if (A < -10 || A > 100)
            {
                Console.WriteLine(" Значение A должно быть в интервале [-10, 100] ");
                return;
            }
            int B;
            B = (int)A % 10;
            if (A == 40||A==0)
            { Console.WriteLine(" {0:F0}`ой ", A);
                return;
            }
            if (B == 1 || B == 4 || B == 5 || B == 9 || B == 10 || B == 0)
            { Console.WriteLine(" {0:F0}`ый ", A); }
            if (B == 2 || B == 6 || B == 7 || B == 8)
            { Console.WriteLine(" {0:F0}`ой ", A); }
            if (B == 3)
            { Console.WriteLine(" {0:F0}`ий ", A); }

        }
    }
}
