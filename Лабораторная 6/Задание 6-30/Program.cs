using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_30
{
    class Program
    {
        static void Main(string[] args)
        {

            double  w,a,b,c,d,e,f,g,h  ;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            e = 0;
            f = 0;
            g = 0;
            h = 0;
            
            Console.Write(" Введите число W  ");
            w = Convert.ToDouble(Console.ReadLine());

            if (w < 1||w>20)
            {
                Console.Write("Значение W должно быть в интервале [0, 20] ");
                return;
            }

            Console.Write("\n");
            while (w > a)
            {
                a =a + 1;

                Console.Write("a");
                
            }
            Console.Write("\n");
            while (w > b)
            {
                b = b + 1;

                
                Console.Write("b");
               
            }
            Console.Write("\n");
            while (w > c)
            {
                c = c + 1;

              
                Console.Write("c");
                
            }
            Console.Write("\n");
            while (w > d)
            {
                d = d + 1;

              
                Console.Write("d");
               
            }
            Console.Write("\n");
            while (w > e)
            {
                e = e+ 1;

               
                Console.Write("e");
              
            }
            Console.Write("\n");
            while (w > f)
            {
                f =f + 1;

               
                Console.Write("f");
               
            }
            Console.Write("\n");
            while (w > g)
            {
                g = g + 1;

              
                Console.Write("g");
               
            }
            Console.Write("\n");
            while (w > h)
            {
                h = h + 1;

              
                Console.Write("h");
            }
            Console.Write("\n");



        }
    }
}
