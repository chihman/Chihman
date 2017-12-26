using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, a, u;
            i = 1;
            int n = 0;
            u = 0;
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
            a = Convert.ToInt32(arr[0]);
            while (i < L)
            {
                n = Convert.ToInt32(arr[i]);
                if (n < a)
                { a = n; }
                i = i + 1;
            }
            i = 0;
           
            while (i < L)
            {
                n = Convert.ToInt32(arr[i]);
                n = n - a;
                Console.Write(n + " ");
                i = i + 1;
            }




        }
    }
}
