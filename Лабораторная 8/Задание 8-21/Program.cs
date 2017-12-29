using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i, x, y, n, L;
            i = 0;
            n = 0;
            x = 0;
            y = 0;
            Console.Write(" Введите  X ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите Y ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите данные ");
            String Q = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Q))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva

            int[] arr2 = new int[L];
            ///
            while (i < L)
            {
                a = Convert.ToInt32(arr[i]);
                if (x == a)
                {
                    arr2[i] = y;
                }
                else { arr2[i] = Convert.ToInt32(arr[i]); }
                i = i + 1;
            }
            i = 0;
            while (i < L)
            {

                Console.Write(arr2[i] + " ");
                i = i + 1;
                n = 0;
            }
        }
    }
}