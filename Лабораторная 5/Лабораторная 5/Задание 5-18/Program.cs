using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_18
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //Дано число А 1000<=A<=9999. Равно ли количество сотен количеству единиц.
            Console.WriteLine("A: ");
            double A = Double.Parse(Console.ReadLine());
            if (A < 1000 || A > 9999)
            {
                Console.WriteLine("Значение A должно быть в интервале [1000, 9999]");
                return;
            }



            if (A % 10 == (A % 1000 - A % 100)/100 )
            {
                Console.WriteLine("равно");
            }

            else
            {
                Console.WriteLine("не равно");
            }
        }
    }
}
