using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, a, u,j;
            j = 1;
            i = 0;
            int n = 0;
            u = 0;
            Console.Write(" Введите данные В ");
            int f1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите данные В ");
            int f2 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите данные   ");
            String Q = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Q))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva


            //////////
           
            while (j <= f2)
            {
                a = Convert.ToInt32(arr[f1+j]);
                n = Convert.ToInt32(arr[f1+i]);
                if (n < a)
                { u = n; }

                j = j + 1;
                i = i + 1;
            }
            i = 0;
            Console.Write(u+" ");

        }
    }
}
