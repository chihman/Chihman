using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
             

                 String r;
            r = Console.ReadLine();
            Double R;
            R = Double.Parse(r);
            Double Vol;
            Vol = (4 * Math.PI * (R*R*R))/3;
            Console.WriteLine("{0:F4}", Vol);




        }
    }
}
