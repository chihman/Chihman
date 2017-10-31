using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A:");
            double A = Double.Parse(Console.ReadLine());



            if (A < 0)
            {
                A = A - A * 2;
                
            }
                        
                           
            Console.WriteLine("Результат " + A);


        }
    }
}
