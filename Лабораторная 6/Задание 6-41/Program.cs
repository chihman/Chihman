using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_41
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            double w, h, j;
            j = 0;
           
            Console.Write(" символ s1 ");
            s1 = Console.ReadLine();
            Console.Write(" символ s2 ");
            s2 = Console.ReadLine();
            Console.Write(" Введите число w  ");
            w = Convert.ToDouble(Console.ReadLine());
            if (w < 0)
            {
                Console.Write("Значение W должно быть >-1 ");
                return;
            }
            Console.Write(" Введите число h  ");
            h = Convert.ToDouble(Console.ReadLine());
            if (h < 0)
            {
                Console.Write("Значение h должно быть >-1 ");
                return;
            }

            //
            j = w;

            while (h > 0)
            {
               
                    while (w > 0)
                    {
                        if (w % 2 != 0)
                        {
                            Console.Write(s1);
                        }
                        else { Console.Write(s2); }
                        w = w - 1;
                    }

                    Console.Write("\n");
                    w = j;
                    h = h - 1;
                

            }

        }
    }
}
