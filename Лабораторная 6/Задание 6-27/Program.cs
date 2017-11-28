using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_27
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, i;
            A = 0;
            B = 0;
            i = 0;

            Console.Write(" Введите число A  ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Введите число B  ");
            B = Convert.ToDouble(Console.ReadLine());
            if (A < B)
            {
                A = A - 1;
                while (A < B)
                {
                    A = A + 1;
                    if (A % 7 == 0)
                    {

                        i = i + A;

                    }

                }
            }
            else
            {
                B = B - 1;
                while (B <= A)
                {
                    B = B + 1;
                    if (B % 7 == 0)
                    {

                        i = i + B;

                    }

                }

            }

            Console.Write("Ответ: " + i);
        }

    }
}
