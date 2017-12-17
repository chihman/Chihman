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
<<<<<<< HEAD

=======
            int i = 0, x = 0, b = 0, s = 0;
>>>>>>> c7f955ac79f9189108b7b69f28feb0c447dfbdfb
            string Q = "abcdacadbacdaabaadc";
            Console.Write(" введите данные ");
            string a = Console.ReadLine();
            s = a.Length;
            if (s!=2)
            {
                Console.Write("Вводимая строка должна содержать ровно 2 символа ");
            }
            
            while (i < 19)
            {
                x = Q.IndexOf(a, b);
                if (b == x)
                {
                    b = x;
                    Console.Write(x + " ");
                }
                i = i + 1;
                b = b + 1;
            }

           
        }
    }
}