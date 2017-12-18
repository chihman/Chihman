using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //no
            Console.Write(" введите данные ");
            string Q = Console.ReadLine();
            int i = 0, x = 0, b = 0, s = 0, j = 0;
          
            j = Q.Length;
            if (s != 1)
            {
                Console.Write("Нужно ввести ровно один символ ");
                return;
            }

            while (i < j)
            {
                x = Q.IndexOf(a, b);
                if (b == x)
                {
                    Console.Write(x + " ");
                }
                i = i + 1;
                b = b + 1;
            }
    }
}
