using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {

            String a;
            a = Console.ReadLine();
            String b;
            b = Console.ReadLine();

            Console.WriteLine("INSERT INTO points (x, y) VALUES ('"+a+"', '"+b+"'); ");

        }
    }
}
