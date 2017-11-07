using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X: ");
            double X = Double.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            double Y = Double.Parse(Console.ReadLine());

            if (Y>=1 && X<=-2)
            {
                Console.WriteLine("Точка принадлежит множеству ");
                return;
            }
                    

            else
            {
                Console.WriteLine("Точка не принадлежит множеству ");
            }

        }
    }
}
