using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание8_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, Hl, tl, g, n, t, I;
            i = 0;
            n = 0;
            t = 0;

            Console.Write(" Введите данные top  ");
            String top = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(top))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] tm = top.Split(' ');
            tl = tm.Length;// dlinna massiva


            Console.Write(" Введите данные left  ");
            String left = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(left))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] lm = left.Split(' ');
            Hl = lm.Length;// dlinna massiva
            Console.Write("  ");
            while (i < tl)
            {
                Console.Write(tm[i] + "  ");
                i = i + 1;
            }
            i = 0;
            Console.Write("\n");
            //////
            I = 0;
            while (I !=Hl )
            {
                Console.Write(lm[I] + " ");

                while (i < tl)
                {
                    if (lm[i]==tm[I])
                    {
                        Console.Write("+");
                    }
                    else { Console.Write("  "); }
                    i = i + 1;
                }
                i = 0;
                I = I + 1;
                Console.Write("  |" + "\n");
            }
            
            i = 0;
            while (i < tl)
            {
               
                    Console.Write("---");
               
                i = i + 1;
            }

            }
    }
}
