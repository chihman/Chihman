using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_38
{
    class Program
    {
        static void Main(string[] args)
        {

            double  A1, A, B;           
            A1 = 0;
            A = 0;
            B = 0;           
            Console.Write(" Введите число A  ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Введите число B  ");
            B = Convert.ToDouble(Console.ReadLine());
            A1 = A;
            if (A < B)
            {
                while (A < B)
                {
                    if (A % 2 != 0)
                    {
                        Console.Write(A);
                        if (A < B - 1) { Console.Write(","); }
                    }
                    A = A + 1;

                }
                if (B % 2 != 0) { Console.Write(B); }
            }
            if (A1 > B)
            {
                while (A1 > B)
                {
                    if (A1 % 2 != 0)
                    {
                        Console.Write(A1);
                        if (A1 - 1 > B) { Console.Write(","); }
                    }
                    A1 = A1 - 1;
                }
                if (B % 2 != 0) { Console.Write(B); }
            }
        }
    }
}

