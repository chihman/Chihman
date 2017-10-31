using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("distanceInKm: ");
            double Km = Double.Parse(Console.ReadLine());
            if (Km<0)
            {
                Console.WriteLine("Значение distanceInKm должно быть неотрицательным");
                return;

            }

            Console.WriteLine("distanceInFeet: ");
            double distanceInFeet = Double.Parse(Console.ReadLine());
            if (distanceInFeet < 0)
                {
                Console.WriteLine("Значение distanceInFeet должно быть неотрицательным");
                return;


            }


            double A;
            A = (distanceInFeet * 0.305) / 1000;


            if (Km < A)
            {
                Console.WriteLine("Расстояние в километрах меньше");
                return;
            }


            Console.WriteLine("Расстояние в футах меньше");



        }
    }
}
