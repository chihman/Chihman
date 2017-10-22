using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
          
                  String b;
           b = Console.ReadLine();
            Double B;
            B = Double.Parse(b);

            String h;
            h = Console.ReadLine();
            Double H;
            H = Double.Parse(h);

            Double area;
            area = (B*H/2) ;
            Console.WriteLine("{0:F2}", area);










        }
    }
}
