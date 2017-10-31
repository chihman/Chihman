using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("velocityInKmH: ");
            double Km = Double.Parse(Console.ReadLine());
            if (Km < 0)
            {
                Console.WriteLine("Значение velocityInKmH должно быть неотрицательным");
                return;

            }

            Console.WriteLine("velocityInMS: ");
            double v = Double.Parse(Console.ReadLine());
            if (v < 0)
            {
                Console.WriteLine("Значение velocityInMS должно быть неотрицательным");
                return;


            }

            double a;   
            a = v*3.6;


            if (Km < a)
            {
                Console.WriteLine(Km+ " км/ч меньше "+v+" м/с");
                return;
            }


            Console.WriteLine(v+" м/с меньше "+Km+ " км/ч");


        }
    }
}
