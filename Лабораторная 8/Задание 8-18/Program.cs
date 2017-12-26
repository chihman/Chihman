using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, a;
            i = 1;
            int n = 0;
          
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

            Console.Write(a + " ");
        }
    }
}
