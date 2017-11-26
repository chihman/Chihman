using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            c = 0;
            a = 19;
            b = 40;

            while (a < b)
            {
                a = a + 1;
                c = c + a * a * a;
                Console.WriteLine(c);
            }

        }
    }
}
