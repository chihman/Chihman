using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Q = "abcdacadbacdaabaadc";
            Console.Write(" введите данные ");
            string A = Console.ReadLine();

            int b = 0, a = 0, x = 0;
            a = Q.IndexOf(ca);
            b = Q.IndexOf(cb);
            if (a > b)
            {
                x = a - b - 1;
                Console.Write(x);
                return;
            }
            if (a < b)
            {
                x = b - a - 1;
                Console.Write(x);
                return;
            }
        }
    }
}