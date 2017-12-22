using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, g, n,t;
            i = 0;
            n = 0;
            t = 0;
            Console.Write(" Введите S ");
            int s = Convert.ToInt32(Console.ReadLine());
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
          
            
            g = s;
            n = L - s;
            t = L - n;
            //////////vpravo

           
            Array.ConstrainedCopy(arr, s, arr2, 0, n);
            Array.ConstrainedCopy(arr, 0, arr2, n, t);

            while (i < L)
            {
                Console.Write(arr2[i] + " ");
                i=i+1;
            }


            return;
            //////
            

            while (s != L)
            {
                arr2[i] = arr[s];
                s = s + 1;
                i=i+1;

            };
            i = 0;

            //
            s = g;
            while (i != g)
            {
                arr2[s] = arr[i];
                s = s + 1;
               i= i+1;

            };
            i = 0;
            //

            while (i != s)
            {
                Console.Write(arr2[i] + " ");
               i= i+1;
            }





        }
    }
}
