using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,  i, n, L;
            i = 0;
            n = 0;
  


            Console.Write(" Введите M ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите данные ");
            String Q = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Q))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva

            while (i < L)
            {
                n = Convert.ToInt32(arr[i]);
                n = n * a;
                Console.Write(n + " ");
                i = i + 1;
                n = 0;

            }

        }

    }

}

