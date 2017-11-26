using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_22
{
    class Program
    {
        static void Main(string[] args)
        {

            double n, i;
            n = 0;
            i = 0;
            Console.Write(" Введите число  ");
            n = Convert.ToDouble(Console.ReadLine());
            if (n < 0)
            { Console.WriteLine("Значение N должно быть неотрицательным "); };
            while (i < n)
            {
                i = i + 1;
                Console.Write("!");
                if (i % 5 == 0)
                { Console.Write(" "); }

            }



        }
    }
}
