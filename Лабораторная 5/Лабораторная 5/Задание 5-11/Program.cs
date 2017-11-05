using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            double A = Double.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            double B = Double.Parse(Console.ReadLine());
            Console.WriteLine("C: ");
            double C = Double.Parse(Console.ReadLine());

            

            if (B>=C)
            {
                Console.WriteLine(" Не Выполняется");
                return;
            }
            
            if (A>=B)
            {
                Console.WriteLine(" Не Выполняется");
                return;
            }
            else
            {
                Console.WriteLine(" Выполняется");
               

            }
            



        }
    }
}
