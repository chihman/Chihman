using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_2
{
    class Program
    {
        static void Main(string[] args)
        {



            String edge;
            edge = Console.ReadLine();
            Double edge2;
            edge2 = Double.Parse(edge);
            Double area;
              area = edge2 * edge2 * 6;
            Console.WriteLine(area);


        }
    }
}
