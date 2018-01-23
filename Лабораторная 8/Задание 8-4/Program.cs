using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b, i,c;
            i = 0;
            Console.Write(" Введите b ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите q ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите данные ");
            String Q = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Q))
            {
                Console.Write("Строка пуста");
                return;
            }

            String[] arr = Q.Split(' ');
           c = arr.Length;
            if (a < 0 || a > c)
            {
                Console.Write("Число b должно быть в интервале [0, размер массива)");
                return;
            }
            if (b < 0 || b > c)
            {
                Console.Write("Число e должно быть в интервале [0, размер массива)");
                return;
            }

            if (a< b)
            {
                while (a+i <= b)
                {
                    Console.Write(arr[a+i] + " ");
                    i++;
                }

            }
            else
            {
                while (b + i <= a)
                {
                    Console.Write(arr[b + i] + " ");
                    i++;
                }
            }


            /// деление массива
            Console.Write(" Введите данные   ");
            String Q = Console.ReadLine();

            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva

        }
    }
}
