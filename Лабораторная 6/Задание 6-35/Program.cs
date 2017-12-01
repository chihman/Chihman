using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_35
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double  H, a,  A;
            a = 0;
           
            A = 0;
            Console.Write(" символ  ");
            s = Console.ReadLine();
            Console.Write(" Введите число H  ");
            H = Convert.ToDouble(Console.ReadLine());
            if (H < 0)
            {
                Console.Write("Значение H должно быть >-1 ");
                return;
            }
            

            while (A < H)
            {
                A = A + 1;
                a = 0;
                while (a < A)
                { Console.Write(s);
                    a = a + 1;
                }
                Console.Write("\n");
                            
            }
        }
    }
}
