using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_30
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("aInGrad:");
            double aInGrad = Double.Parse(Console.ReadLine());

            Console.WriteLine("bInGrad:");
            double bInGrad = Double.Parse(Console.ReadLine());

            Double aInRad, bInRad;
            aInRad = aInGrad * Math.PI / 180;
            bInRad = bInGrad * Math.PI / 180;
            
            double result1;
            result1 = Math.Sin(aInRad)*Math.Cos(bInRad) + Math.Cos(aInRad)*Math.Sin(bInRad);


            Console.WriteLine("Результат: {0:F4}", result1);




        }
    }
}
