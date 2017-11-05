using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sc: ");
            double Sc = Double.Parse(Console.ReadLine());


            if (Sc < 0)
            {
                Console.WriteLine("Площадь круга должна быть положительной ");
                return;
            }


            Console.WriteLine("Ss: ");
            double Ss = Double.Parse(Console.ReadLine());

            if (Ss < 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положительной ");
                return;
            }

            //Write('введите площадь круга и квадрата');
            //Readln(s1, s2);
            //A:= sqrt(s2);
            //R:= sqrt(s / 3.14);
            //If(r < a / 2) then writeln(' круг уместится в квадрате') 
            //Else writeln(' круг не уместится в квадрате');
            //If(a * sqrt(2)) > (4 * r) then writeln('квадрат уместится в круге')
            //Else Writeln('квадрат не уместится в круге');

            double A, B;
            A = Math.Sqrt(Ss);
            B = Math.Sqrt(Sc / 3.14);

            if (B < A / 2)
            {
                Console.WriteLine("круг уместится в квадрате");
            }
            else {
                Console.WriteLine("Круг не поместится в квадрате");
        }
        }
    }
}
            



         





            