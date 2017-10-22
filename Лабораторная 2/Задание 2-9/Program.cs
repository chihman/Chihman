using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите aInitial:");
            String aInitial;
            aInitial = Console.ReadLine();
            Double A;
             A = Double.Parse(aInitial);

            Double B;
            B = A % 360;
            Console.WriteLine("aRemainder = " +  B);




            


        }
    }
}
