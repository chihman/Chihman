using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Q = "abcdefwxyz";
            Console.Write(" введите са ");
            string ca = Console.ReadLine();
            if (Q.Contains(ca))
            {
               
            }
            else
            {
                Console.Write(" Значение CA отсутствует в строке ");
                return;
            }
            Console.Write(" введите сb ");
            string cb = Console.ReadLine();
            if (Q.Contains(cb))
            {
               
            }
            else
            {
                Console.Write(" Значение Cb отсутствует в строке ");
                return;
            }
            int b = 0, a = 0, x = 0;
            a = Q.IndexOf(ca);
            b = Q.IndexOf(cb);
            if (a > b)
            {
                x = a - b - 1;
                Console.Write(x + " \n ");
                return;
            }
            if (a < b)
            {
                x = b - a - 1;
                Console.Write(x+" \n ");
                return;
            }
        }
    }
}
