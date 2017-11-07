using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X: ");
            double X = Double.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            double Y = Double.Parse(Console.ReadLine());

            if (X <= 4 && Y >= 2)
            {
                if (X <= 1)
                {
                    Console.WriteLine("Точка принадлежит множеству ");
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит множеству ");


                }
            }
            else
            {
                Console.WriteLine("Точка не принадлежит множеству ");
            }

        }
    }
}
