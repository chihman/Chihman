using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание6_39
{
    class Program
    {
        static void Main(string[] args)
        {
            double j, p, q;
            j = 0;
            
            Console.Write(" Введите число p  ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Введите число q  ");
            q = Convert.ToDouble(Console.ReadLine());

            if (p < q)
            {
                j = (q - p) / 2;
                j = j + p;

                while (p <= q)
                {
                    Console.Write(p);
                    if (p < j) { Console.Write("<"); }
                    else { Console.Write(">"); }
                    p = p + 1;
                }
            }
            else
            {
                j = (p - q) / 2;
                j = j + q;
                while (q <= p)
                {
                    Console.Write(q);
                    if (q < j) { Console.Write("<"); }
                    else { Console.Write(">"); }
                    q = q + 1;
                }
            }
        }
    }
}

