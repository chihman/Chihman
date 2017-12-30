using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, j, I,e;

            j = 0;
            i = 0;
            I = 0;
            e = 0;
            int n = 0;


            Console.Write(" Введите данные   ");
            String Q = Console.ReadLine();

            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva
            int[] arr2 = new int[L];

            //////////
            while (I < L)
            {
                while (L > i + I)
                {
                    int a = Convert.ToInt32(arr[I]);
                    int b = Convert.ToInt32(arr[I+i]);
                    if (a == b)
                    {
                        if (j != a)
                        {
                            j = a;
                            arr2[e] = a;
                            e++;
                            i = L;
                        }
                    }
                    i = i + 1;

                }
                i = 0;
                I = I + 1;
               
                n = n + 1;


            }
            i = 0;
            L = e;
            while (i < L)
            {
                Console.Write(arr2[i]);
                i++;

            }
        }
    }
}
