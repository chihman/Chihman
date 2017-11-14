using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные A1: ");
            double A1 = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите данные B1: ");
            double B1 = Double.Parse(Console.ReadLine());

            if (A1 > B1)
            {
                Console.WriteLine(" Значение A должно быть меньше значения B ");
                return;
            }
            Console.WriteLine("Введите данные A2: ");
            double A2 = Double.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите данные B2: ");
            double B2 = Double.Parse(Console.ReadLine());

            if (A2>B2)
            {
                Console.WriteLine(" Значение A должно быть меньше значения B ");
                return;
            }
            
            double A,B;
            if (A1 > A2)
            { A = A1; }
            else { A = A2; }

            if (B1 < B2)
            { B = B1; }
            else { B = B2; }

            if (B1<A2 || B2<A1 )
            {
                Console.WriteLine(" не пересекаются ");
                return;
            }
          
            if (B2>=A1 || B1>=A2)
            {                               
                Console.WriteLine(" Пересекаются  ({0:F0};{1:F0})", A , B);
                            }
            
            


        }
    }
}
