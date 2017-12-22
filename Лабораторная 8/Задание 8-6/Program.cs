using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, g;
            i = 0;
            g = 1;
            string m;
            m = "l";
            Console.Write(" Введите данные ");
            String Q = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(Q))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva
            string[] arr2 = new string[L];
            arr2[0] = "0";

            m = arr[L-1];
            while (i < L)
            {
                if (g <L)
                {
                    arr2[g] = arr[i];
                }
                i++;
                g = i + 1;
            };
            arr2[0] = m;
             
            i = 0;
            while (i < L)
            {
                Console.Write(arr2[i]+" ");
                i++;

            }
           
        }



    }
}

