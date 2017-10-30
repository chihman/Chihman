using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
                String edge;
            edge = Console.ReadLine();
            Double A;
            A = Double.Parse(edge);
            if (A <= 0)
            {
                Console.Write("Значение edge должно быть положительным ");
                return;
            }
            Double volume;
            volume = A * A * A;
            Console.WriteLine(volume);
     
        }
    }
}
