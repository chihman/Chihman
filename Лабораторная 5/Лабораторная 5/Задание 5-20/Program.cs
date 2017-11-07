using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Y: ");
            double Y = Double.Parse(Console.ReadLine());

            if (Y >= -2 && Y <= 1.5)
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
