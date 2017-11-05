using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_17
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("M: ");
            double M = Double.Parse(Console.ReadLine());
            double A;

            Console.WriteLine("P: ");
            double P = Double.Parse(Console.ReadLine());
            if (P == 0)
            {
                Console.WriteLine("Значение P должно быть не равно нулю");
                return;
            }


            if (M % P != 0)
            {
                Console.WriteLine("M не делится нацело на P");

            }
            else
            {
                A = M / P;
                Console.WriteLine(A);
            }
        }
    }
}
