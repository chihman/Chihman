using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
          
                String aInGrad;
            aInGrad = Console.ReadLine();
            Double G;
            G = Double.Parse(aInGrad);

            Double aInRad;
            aInRad = G*Math.PI/180;
            Console.WriteLine("{0:F4}", aInRad);







        }
    }
}
