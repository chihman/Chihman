using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_32
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double w, h, a,z,A;
            a = 0;
            z = 0;
            A = 0;
            Console.Write(" символ  ");
            s = Console.ReadLine();
            Console.Write(" Введите число w  ");
            w = Convert.ToDouble(Console.ReadLine());

            if (w < 0 )
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
            z = h * w;
            
            while (z > a)
            {
                a = a + 1;
                A = a % w;
                Console.Write(s);
                if (A==0)
                { Console.Write("\n"); }
            }

        }
    
    }
}
