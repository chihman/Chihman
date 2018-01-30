using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Проверка_курсовой
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для увличения исходного файла до 2,5ГБ нажмите 1 ");
            int n = int.Parse(Console.ReadLine());
            if (n != 1)
            { return; }
            if (!File.Exists("..\\..\\voina i mir.txt")) //проверяет наличие файла
            {
                Console.Write("oshibka fail ne sushestvuet");
                return;
            }
            StreamReader reader = new StreamReader("..\\..\\voina i mir.txt", Encoding.GetEncoding("Windows-1251")); //читает файл
            if (reader.EndOfStream)
            {
                Console.Write("Файл пуст");
                return;
            }


            int  j = 0;
        

            String filename = "test100.txt";//
            StreamWriter writer = new StreamWriter(filename, false, Encoding.Unicode);// создание файла для вывода
            while (j < 500)
            {
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine(); //читает первую строку

                    writer.WriteLine(line);//вывод в файл


                }
                j++;
            reader = new StreamReader("..\\..\\voina i mir.txt", Encoding.GetEncoding("Windows-1251")); //читает файл

            }
            writer.Close();//вывод в файл, конец
        }
    }
}
