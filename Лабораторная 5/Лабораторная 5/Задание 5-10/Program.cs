using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X: ");
            double X = Double.Parse(Console.ReadLine());
            
            double  x, y, z;

            if (X < 0)
            {
                x = X;
                
            }
            else
            {
                x = Math.Pow(X,2);

            }
            Console.WriteLine("Y: ");
            double Y = Double.Parse(Console.ReadLine());
            if (Y < 0)
            {
                y = Y;

            }
            else
            {
                y = Math.Pow(Y,2);

            }
            Console.WriteLine("Z: ");
            double Z = Double.Parse(Console.ReadLine());
            if (Z < 0)
            {
                z = Z;

            }
            else
            {
                z = Math.Pow(Z,2);

            }
            Console.WriteLine("{0:F4};{1:F4};{2:F4}",x,y,z);
            



        }
    }
}
