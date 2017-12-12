using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_6
{
    class Program
    {
        static void Main(string[] args)
        {

            String a, b, c;
            int x, y;
            Console.Write("Введите СА ");
            a = Console.ReadLine();

            Console.Write("Введите СB ");
            b = Console.ReadLine();

            string Q = "abcdefwxyz";
            x = Q.IndexOf(a);
            y = Q.IndexOf(b);
            if (x < y)
            {
                c = Q.Substring(x-1, y);
            }
            else { c = Q.Substring(y-1,x); }
            Console.Write(c);
        }
    }
}
