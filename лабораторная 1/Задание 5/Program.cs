﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            String b;
            b = Console.ReadLine();
            Console.Write(b + a);
          
            Console.Write(b);
            Console.Write(a);

            Console.WriteLine(" {0:F4} ", b);
            Console.WriteLine(" {0:F4}", a);



        }
    }
}
