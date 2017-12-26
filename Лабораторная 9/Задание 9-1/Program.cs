using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//обязательная строка



namespace Задание_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (!File.Exists("..\\..\\test" + n + ".txt")) //проверяет наличие файла
            { Console.Write("oshibka fail ne sushestvuet");
                return;
            }
            StreamReader reader = new StreamReader("..\\..\\test" + n + ".txt"); //читает файл
            if (reader.EndOfStream)
            {
                Console.Write("Файл пуст");
                return;
            }
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine(); //читает первую строку
                Console.Write(line + " ");
            }
          

        }
    }
}
