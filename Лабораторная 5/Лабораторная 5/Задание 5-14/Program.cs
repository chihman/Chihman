﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("X: ");
            double X = Double.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            double Y = Double.Parse(Console.ReadLine());
            Console.WriteLine("Z: ");
            double Z = Double.Parse(Console.ReadLine());
            double x, y, z;
            
            if (X >= -3 && X <= 5)
            {
                x = X;
                Console.Write(" " + x);
            }
            if (Y >= -3 && Y <= 5)
            {
                y = Y;
                Console.Write(" " + y);
            }
            if (Z >= -3 && Z <= 5)
            {
                z = Z;
                Console.Write(" " + z);
            }









        }
    }
}
