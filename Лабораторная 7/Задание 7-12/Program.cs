using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_12
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write(" введите данные ");
            string a = Console.ReadLine();

            int i = 0, x = 0, g=0;
            g = a.Length;
            while (i < g)
            {
                i = i + 1;
                x = a.IndexOf(",");

                Console.Write(x+1);
            }

        }
    }
}
