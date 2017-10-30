using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_37
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("V1:");
            double V1 = Double.Parse(Console.ReadLine());
            if (V1< 0)
            {
                Console.Write("Объем должен быть неотрицательным ");
                return;
            }


            Console.WriteLine("T1:");
            double T1 = Double.Parse(Console.ReadLine());

            
            Console.WriteLine("V2:");
            double V2 = Double.Parse(Console.ReadLine());
            if (V2 < 0)
            {
                Console.Write("Объем должен быть неотрицательным ");
                return;
            }


            Console.WriteLine("T2:");
            double T2 = Double.Parse(Console.ReadLine());



            double result1, result2;



            result1 = V1 + V2;
            result2 = (T1 * V1 + T2 * V2) / result1;


            Console.WriteLine("volume: {0:F4}", result1);
            Console.WriteLine("temperature: {0:F4}", result2);




        }
    }
}
