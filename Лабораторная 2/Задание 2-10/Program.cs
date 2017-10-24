using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_10
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите данные(xInGrad):");
            double  xInGrad = Double.Parse (Console.ReadLine());
            double result;
           result = xInGrad * Math.PI / 180;
            result = Math.Sin(result);
             Console.WriteLine("sin(xInRad) = {0:F4}", result);
            



        }
    }
}
