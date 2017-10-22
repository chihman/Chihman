using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задане_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
                String r;
            r = Console.ReadLine();
            Double R;
            R= Double.Parse(r);
            Double cir;
            cir = 2 * Math.PI * R;
            Console.WriteLine("{0:F4}", cir);



        }
    }
}
