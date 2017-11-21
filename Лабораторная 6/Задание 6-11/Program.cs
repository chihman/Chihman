using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, n;


            Console.Write("Введите А ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a>500 ||a <-100)
            { Console.WriteLine("Значение A должно быть в интервале [-100, 500]"); };
            b = 500;
            n = a;
            if (a < b) 
            {
                while (a < b)
                {
                    a = a + 1;
                    
                    n = n + a;

                }
            } 
        
                else
                {
                while (a > b)
                {
                    a = a - 1;
                   
                    n = n + a;

                }
            }
            Console.Write(n);


        }
    }
}
