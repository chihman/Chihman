using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" введите данные ");
            string a = Console.ReadLine();

            int i = 0, x = 0, g = 0, b = 0, u=0;
            g = a.Length;

            if (b == x)
                while (i < g)
                {
                    x = a.IndexOf(",", b);
                    if (b == x)
                    {
                        u = u+1;
                    }
                    i = i + 1;
                    b = b + 1;
                }
            Console.Write(u+1 + " ");
        }
    }
}
