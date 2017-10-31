using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P:");
            double P = Double.Parse(Console.ReadLine());
            Console.WriteLine("Q:");
            double Q = Double.Parse(Console.ReadLine());


            if (P > Q)
            {
                Console.Write("Максимальное " +P+ ", "+ "Минимальное " +Q+ " ");

            }
            else
            {
                Console.Write("Максимальное " +Q+ ", "+ "Минимальное " +P + " ");


            }


        }
    }
}
