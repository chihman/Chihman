using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, I, l;
            l = 1;
            i = 1;
            I = 0;
            int n = 0;

            Console.Write(" Введите данные   ");
            String Q = Console.ReadLine();

            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva

            string r = arr[0];
            // povtory
            while (I < L)
            {
                i = 1;
                l = 0;
                while (L > i + I)
                {
                    int a = Convert.ToInt32(arr[I]);
                    int b = Convert.ToInt32(arr[I + i]);
                    if (a == b)
                    {

                        l = l + 1;
                    }
                    i = i + 1;

                }
                if (l == 0)
                {
                    n = n + 1;
                }

                I = I + 1;

            }

            Console.Write(" unikalnye  " + n + " \n");
        }
    }
}
