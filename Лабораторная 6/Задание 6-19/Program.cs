using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, i, c;
            c = 0;
            n = 0;
            i = 0;
            
            while (n <= 83 || n >= 199)
            {
                Console.Write(" Введите число  ");
                n = Convert.ToDouble(Console.ReadLine());
                
                if (n <= 83)
                { c = c + 1; }
                if (n >= 199)
                { i = i + 1; }
               
            }

            Console.WriteLine("Количество слева: " + c + " количество справа: " + i);
           
        }
    }
}
