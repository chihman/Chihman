using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int  i,  L;
            Double n, a;
            i = 0;
            n = 0;
            a = 0;
           

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
                a = a +n;
                
                i = i + 1;
                
            }
            a = a / L;
            Console.Write(a + " ");

        }
    }
}
