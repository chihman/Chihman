using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int  I, i, L1, L2, n;
            i = 0;
            n = 0;
            I = 0;
            Console.Write(" Введите данные top ");
            String D = Console.ReadLine();

            Console.Write(" Введите данные left ");
            String Q = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Q))
            {
                Console.Write("Строка left пуста");
                return;
            }

            if (String.IsNullOrWhiteSpace(D))
            {
                Console.Write("Строка top пуста");
                return;
            }

            String[] arr1 = Q.Split(' ');
            L1 = arr1.Length;
            String[] arr2 = D.Split(' ');
            L2 = arr2.Length;


            ///////////////

            while (I < L2)
            {
                while (L1 > i)
                {
                    if (arr1[I] == arr2[i])
                    {
                        n = n + 1;

                    }
                    i = i + 1;

                }
                i = 0;
                I = I + 1;
            }

            Console.Write( " Повторений: "+n);



        }
    }
}
