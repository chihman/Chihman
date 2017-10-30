using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_34
{
    class Program
    {
        static void Main(string[] args)
        {

            //см 2-30
            Console.WriteLine("aInGrad:");
            double aInGrad = Double.Parse(Console.ReadLine());

            Console.WriteLine("bInGrad:");
            double bInGrad = Double.Parse(Console.ReadLine());

            Double aInRad, bInRad;
            aInRad = aInGrad * Math.PI / 180;
            bInRad = bInGrad * Math.PI / 180;

            double result1;
            result1 = 3*Math.Sin(2*aInRad)*Math.Cos(3*bInRad);


            Console.WriteLine("Результат: {0:F4}", result1);


        }
    }
}
