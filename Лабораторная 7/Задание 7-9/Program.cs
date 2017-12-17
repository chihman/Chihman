using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_9
{
    class Program
    {
        static void Main(string[] args)
        {

            String a, b, A;       
           
            Console.Write("Введите данные ");
            a = Console.ReadLine();
            A= a.Substring(0,1);
            if (A=="s")
            { b = a.ToLower();
                Console.Write(b);
                return;
            }
                   
            if (A=="U")
            {
                b=a.ToUpper();
                Console.Write(b);
                return;
            }
            Console.Write(a);

        }
    }
}
