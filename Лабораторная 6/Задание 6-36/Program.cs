using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_36
{
    class Program
    {
        static void Main(string[] args)
        {
            double H, a, A, a1, b1;
            a = 0;
            A = 0;
            a1 = 0;
            b1 = 0;
            H = 0;
            Console.Write(" Введите число A  ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Введите число B  ");
            b1 = Convert.ToDouble(Console.ReadLine());

            if (a1 > b1)
            {
                if (b1 % 2 == 0)
                    b1 = b1 + 1;
                while (b1 <= a1)
                {

                    H = H + 1;
                    while (A < H)
                    {
                        A = A + 1;
                        a = 1;
                        while (a < A)
                        {
                            Console.Write(".");
                            a = a + 1;
                        }
                        Console.Write(b1);
                        b1 = b1 + 2;
                        Console.Write("\n");

                    }
                }
            }
            else
            {
                if (a1 % 2 == 0)
                    a1 = a1 + 1;
                while (a1 <= b1)
                {

                    H = H + 1;
                    while (A < H)
                    {
                        A = A + 1;
                        a = 1;
                        while (a < A)
                        {
                            Console.Write(".");
                            a = a + 1;
                        }
                        Console.Write(a1);
                        a1 = a1 + 2;
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}

