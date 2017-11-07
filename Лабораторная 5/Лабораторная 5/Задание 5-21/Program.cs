using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X: ");
            double X = Double.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            double Y = Double.Parse(Console.ReadLine());

            if (X <= 2 && X >= 1)
            {
                if (Y <= 4)
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
    
