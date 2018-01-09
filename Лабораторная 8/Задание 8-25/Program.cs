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
            int i, L, j, I, e, l;
            l = 1;
            j = 0;
            i = 1;
            I = 0;
            e = 0;
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
            i = 0;
            I = 0;
           
            e = 0;
            l = 0;
            string [] arr2 = new string[L];
            //////////
            string A= " ";
           
                i = 0;
               
                while (L >  I)
                {
                while (i < L)
                {
                    if (arr2[I] != arr[i] && A != arr[i])
                    {
                        arr2[I] = arr[i];
                        A = arr2[I];
                        i = L;
                    }
                    i++;
                }
                I++;
                i = I;
                }
            //
            i = 0;
            while (i < n)
            {
                Console.Write(arr2[i]);
                i++;
            }
        }
    }
}
