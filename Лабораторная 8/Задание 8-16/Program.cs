using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, l;
            Double n,m, a;
            i = 0;
            n = 0;
            a = 0;
            m = 0;

            Console.Write(" Введите данные left ");
            String Q = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Q))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva
            ///
            Console.Write(" Введите данные right ");
            String W = Console.ReadLine();
            
            if (String.IsNullOrWhiteSpace(W))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] arr2 = W.Split(' ');
            l = arr2.Length;// dlinna massiva
            if (L!=l)
            { Console.Write( "Размеры массивов должны быть равны ");
                return;
            }
            //////////
            while (i < L)
            {
                n = Convert.ToInt32(arr[i]);
                m = Convert.ToInt32(arr2[i]);
                i = i + 1;
                a = n * m;
                Console.Write(a + " ");
            }
          
        }
    }
}
