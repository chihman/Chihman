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
            int i, L, a, j;
            a = 0;
            j = 1;
            i = 0;
            int n = 0;

            Console.Write(" Введите данные p ");
            int f1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите данные q ");
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

            if (f1 > L || f2 > L)
            {
                Console.Write("oshibka");
                return;
            }
            if (f2 <= 0 || f1 <= 0)
            { Console.Write("oshibka"); return; }
            
            //////////

            a = Convert.ToInt32(arr[f1]);
            while (i <= L)
            {
                if (i >= f1 && i <= f2)
                {
                    n = Convert.ToInt32(arr[i]);
                    if (n < a)
                    { a = n; }

                }
                i = i + 1;
            }
            i = 0;
            Console.Write(a + " ");

        }
    }
}
