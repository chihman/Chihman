using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_23
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

          
            Console.Write(" Введите данные k ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите данные   ");
            String Q = Console.ReadLine();

          
            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva

            //////////

            i = 0;
            while (i < L)
            {
                n = Convert.ToInt32(arr[i]);
                if (k==n)
                {
                    a = a + 1;

                }
                i = i + 1;
            }
            if ()
            {
                Console.WriteLine("втречается);
            }
           
            Console.Write(a + " ");
        }
    }
}
