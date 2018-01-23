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
            int i = 0, x = 0, b = 0, x1 = 0, y1=0,y = 0, j = 0, r = 0, Y = 0;
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine(); //читает первую строку
                int L = line.Length;
                r = r++;//колличество строк
                //

                j = line.Length;
                i = 0;

                
                while (i < j)
                {
                    x = line.IndexOf("{", i);
                    y = line.IndexOf("}", i);
                    if (x == i)
                    {
                        b = b + 1;
                        x1++;
                    }
                    if (y == i)
                    {
                        b = b - 1;
                        y1++;
                    }
                    if (Y < b)
                    { Y = b; }
                    i++;

                }
                

            }
            if (y1 > x1)
            {
                Console.Write(" неожиданная закрывающаяся скобка ");
                return;
            }
            if (x1!=y1)
            {

                Console.Write(" Неожиданный конец файла ");
                return;
            }
           
            Console.Write(Y);
        }
    }
}
