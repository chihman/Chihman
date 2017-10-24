using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_11
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вычислить результат по формуле x



            Console.WriteLine("Введите данные X:");
            double A = Double.Parse(Console.ReadLine());
            double result;

            if  (A < 0)
            {
                Console.Write("Значение X должно быть неотрицательным ");
                return;
            }

            result = Math.Sqrt(A);
            
            Console.WriteLine("X = {0:F4}", result);


        }
    }
}
