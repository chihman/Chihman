using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" введите данные ");
            string Q = Console.ReadLine();
            int i = 0, x = 0, b = 0, y = 0, j = 0;

            j = Q.Length;

            while (i < j)
            {
                x = Q.IndexOf("{", i);

                if (x == i)
                {
                    b = b + 1;
                    Console.Write(b);
                }

                y = Q.IndexOf("}", i);
                if (y == i)
                {
                    b = b - 1;
                    Console.Write(b);
                }
                i = i + 1;
            }
            if (j % 2 != 0)
            {
                if (b < 0)
                {
                    Console.Write(" неожиданная закрывающаяся скобка ");
                    return;
                }
                Console.Write(" Неожиданный конец строки ");
            }



        }
    }

}
