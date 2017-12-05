using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = 0, c= 0,x=0;
            string input = "abcdefwxyz";
            b =input.IndexOf(a);
            b = b + 1;
            c = input.Length;                    
            if (b>c)
            { Console.Write("Значение отсутствует в строке");
                return;
            }

            x = c - b;
            
            Console.Write(x);
        }
    }
}
