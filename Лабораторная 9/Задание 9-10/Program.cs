using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_9_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite nomer testa ");
            int n = int.Parse(Console.ReadLine());

            if (!File.Exists("..\\..\\test" + n + ".txt")) //проверяет наличие файла
            {
                Console.Write("oshibka fail ne sushestvuet");
                return;
            }
            StreamReader reader = new StreamReader("..\\..\\test" + n + ".txt"); //читает файл
            if (reader.EndOfStream)
            {
                Console.Write("Файл пуст");
                return;
            }
            int i = 0, x = 0, b = 0, b2 = 0, y = 0, j = 0, r = 0;
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine(); //читает первую строку
                int L = line.Length;

                //

                j = line.Length;
                i = 0;
                while (i < j) { 
                x = line.IndexOf("{", i);

                if (x == i)
                {
                    b = b + 1;

                }

                y = line.IndexOf("}", i);
                if (y == i)
                {
                  //  b2 = b2 - 1;

                }
                i = i + 1;
            }
                    r = b+b2;
               
                
                
                //     if (j % 2 != 0)
                //    {
                //        if (b < 0)
                //       {
                //            Console.Write(" неожиданная закрывающаяся скобка ");
                //            return;
                //       }
                //        Console.Write(" Неожиданный конец строки ");
                //   }

            }
            Console.Write(r);
        }
    }
}
