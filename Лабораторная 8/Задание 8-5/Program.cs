using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, c;
            i = 0;
            string m ;
            m = "l";
            Console.Write(" Введите b ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите e ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите данные ");
            String Q = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Q))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] arr = Q.Split(' ');
            c = arr.Length;// dlinna massiva
            if (a < 0 || a > c)
            {
                Console.Write("Число Р должно быть в интервале [0, размер массива)");
                return;
            }
            if (b < 0 || b > c)
            {
                Console.Write("Число Q должно быть в интервале [0, размер массива)");
                return;
            }


            while (i < c)
            {
                if (i == a)
                {
                    m = arr[i];
                    arr[i] = arr[b];
                }
               

                i++;
            };
            i = 0;
            while (i < c)
            {
                if (i == b)
                {
                    arr[i] = m;
                }
                Console.Write(arr[i] );
                i++;

            }
            while (i < c)
            {
               
                Console.Write(arr[i]);
                i++;
            }
        }



    }
}
