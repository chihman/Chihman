using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_16
{
    class Program
    {
        static void Main(string[] args)
        {

            //Даны действительные числа x, y, z. Вывести на экран значение наибольшего из них.


            Console.WriteLine("X: ");
            double X = Double.Parse(Console.ReadLine());


            Console.WriteLine("Y: ");
            double Y = Double.Parse(Console.ReadLine());

            Console.WriteLine("Z: ");
            double Z = Double.Parse(Console.ReadLine());



            if (X > Y && X > Z)
            {

                Console.WriteLine( "ответ"+ X);
            }

            if (Y > X && Y > Z)
            {

                Console.WriteLine("ответ"+ Y);
            }
            if (Z > Y && Z > X)
            {

                Console.WriteLine("ответ"+ Z);
            }

        }
    }
}
