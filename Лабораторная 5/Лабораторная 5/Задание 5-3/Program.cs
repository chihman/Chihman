using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("K:");
            double K = Double.Parse(Console.ReadLine());
           


            if (K > 0)
            {

                K = Math.Sqrt(K);
                Console.WriteLine("Результат "+ K);

            }
            else
            {
                K = Math.Pow(K,2);
                Console.WriteLine("Результат "+ K);

            }




        }
    }
}
