using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_17
{
    class Program
    {
        static void Main(string[] args)
        {

            double n, i,  c;
            c = 0;
            n = 1;
            i = 0;
           
            while (n != 0)
            {
                Console.Write("Введите число  ");
                n = Convert.ToDouble(Console.ReadLine());

                i = i + 1;
                c = c+n;              
                         }
            Console.WriteLine(" Сумма чисел: "+c+ " Количество чисел: " + i);

          
        }
    }
}
