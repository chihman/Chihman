using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8__22
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, L, a, u;
            i = 1;
            int n = 0;
            u = 0;
            Console.Write(" Введите данные   ");
            String Q = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Q))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva
            int[] anArray = new int[L];

            //////////
            while (i < L)
            {
                anArray[i] = Convert.ToInt32(arr[i]);
                i++;
            }
            /////
            i = 0;
            //Основной цикл (количество повторений равно количеству элементов массива)
            for ( i = 0; i < anArray.Length; i++)
            {
                //Вложенный цикл (количество повторений, равно количеству элементов массива минус 1 и минус количество выполненных повторений основного цикла)
                for (int j = 0; j < anArray.Length - 1 - i; j++)
                {
                    //Если элемент массива с индексом j больше следующего за ним элемента
                    if (anArray[j] > anArray[j + 1])
                    {
                        //Меняем местами элемент массива с индексом j и следующий за ним
                        Swap (ref anArray[j], ref anArray[j + 1]);
                    }
                }

          

            }
            i = 0;
            while (i < L)
            {
                Console.Write(anArray[i]);

                i = i + 1;
            }

        }

        private static void Swap(ref int v1, ref int v2)
        {
            throw new NotImplementedException();
        }
    }
}