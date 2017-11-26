using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, n,c;
   
            b = 0;
            c = 0;
            Console.Write("Введите А ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a > 10000 || a < -10)
            { Console.WriteLine("Значение A должно быть в интервале [-100, 500]"); };

            n = -11;
            while (n < a)
                {
                n = n + 1;
                c = c + n;
                             }

            Console.WriteLine( c);

           
        }
    }
}
