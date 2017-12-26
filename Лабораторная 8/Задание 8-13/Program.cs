using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int I, i, L1;
            i = 1;
           
            I = 0;
       

            Console.Write(" Введите данные ");
            String Q = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Q))
            {
                Console.Write("Строка пуста");
                return;
            }

         

            String[] arr1 = Q.Split(' ');
            L1 = arr1.Length;
           


            ///////////////

            while (I <= L1)
            {
                while (L1 > i)
                {
                    if (arr1[I] == arr1[i])
                    {                       
                        Console.Write(" Повторения есть " );
                        return;
                    }
                    i = i + 1;

                }
                i = I+1;
                I = I + 1;
            }
            Console.Write(" Повторений нет ");

        }
    }
}
