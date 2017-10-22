using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну рулона (в метрах):");
            String totalInM;
           totalInM = Console.ReadLine();
            Double M;
            M = Double.Parse(totalInM);

            Console.WriteLine("Введите длинну материала для изготовления одной вещи (в см):");
            String partInCm;
            partInCm = Console.ReadLine( );
            Double Cm;
            Cm = Double.Parse(partInCm);


            
            Double thing;
            thing = (M*100)/Cm ;
            Console.WriteLine("Всего вещей " + "{0:F0}", thing);

            Double obrezki;
            obrezki = (M * 100) % Cm;
            Console.WriteLine("Плюс " + obrezki + "см обрезков");

            






            
        }
    }
}
