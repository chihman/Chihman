using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2_22
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вычислить силу трения по формуле.Значение угла дано в градусах.force = mass * g * cos(aInRad), где g -ускорение свободного падения, приблизительно равное 9,8067

            Console.WriteLine("mass: ");
            double mass = Double.Parse(Console.ReadLine());



            if (mass <= 0)
            {
                Console.Write("Масса должна быть положительной ");
                return;
            }



            Console.WriteLine("aInGrad: ");
            double aInGrad = Double.Parse(Console.ReadLine());
           
            
            double result, result2;


            result = aInGrad*Math.PI/180;
            result2 = mass * 9.8067 * Math.Cos(result);

            Console.WriteLine("сила трения= {0:F4}", result2);











        }
    }
}
