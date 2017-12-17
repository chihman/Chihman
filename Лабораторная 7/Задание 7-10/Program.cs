using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string Q = "abcdacadbacdaabaadc";

            Console.Write(" введите данные ");
            string a = Console.ReadLine();

            int z;
            z = Q.Length; //длинна строки
            int i = 0, x=0, c = 0;
            string v;
          
            while (i < 19)
            {



                c = Q.IndexOf(a); //место переменной

                v = Q.Substring(0, c);
                Console.Write(v);              
                x = c;

                c = Q.IndexOf(a);
                v = Q.Substring(x, c);
                Console.Write(v);
                c = Q.IndexOf(a);
                v = Q.Substring(c, z);
                Console.Write(v);
                i = i + 2;
                //no
            }
            
            
        }
    }
}
