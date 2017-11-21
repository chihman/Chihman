using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double a;
            string b;
            Console.Write("Введите А");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите B");
            b = Console.ReadLine();
            if (a<0)
            {
                Console.Write("значение А должно быть не отрицательным ");
                return;
            }
            else
            {
                Console.Write("\"");
                while (a != n)
                {
                    Console.Write(b);

                    n=n+1;
                }
                Console.Write("\"");
            }
        }
    }
}
