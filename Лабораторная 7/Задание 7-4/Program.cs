using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Q = "abcdacadbacdaabaadc";
            Console.Write(" введите данные ");
            string a = Console.ReadLine();

            int i = 0, x = 0;
            while (i < 19)
            {
                i=i+2;
                x = Q.IndexOf(a);

                Console.Write(x);
            }

            //no
        }
    }
}