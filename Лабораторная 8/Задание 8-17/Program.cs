using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, l;
            Double n, m;
            i = 0;
            n = 0;
            l = 0;
            m = 0;

            Console.Write(" Введите данные В ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите данные   ");
            String Q = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Q))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva

            if (a > L || a < 0)
            { Console.WriteLine("Число B должно быть в интервале[0, размер массива) ");
                return;
            }

            //////////
            a= Convert.ToInt32(arr[a]);
            while (i < L)
            {
                n = Convert.ToInt32(arr[i]);
                if (n < a)
                { l = l + 1; }
                i = i + 1;
            }

            Console.Write(l + " ");
        }
    }
}

