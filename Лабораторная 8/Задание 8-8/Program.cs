using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, n;
            i = 0;
            
            n = 0;
            String g;
           
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
            n = L;
            while (n > i)
            {

                g = arr[L-1];
                arr2[i] = g;
                i = i+1;
                L = L - 1;
            }
            i = 0;
            while (i < n)
            {
                Console.Write(arr2[i] + " ");
                i=i+1;
            }
        }
    }
}
