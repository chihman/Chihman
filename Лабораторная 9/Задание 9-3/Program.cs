using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//обязательная строка

namespace Задание_9_3
{
    class Program
    {
        static void Main(string[] args)
        {// otkryt' fail iz seti
          
            int n = int.Parse(Console.ReadLine());
            string A = "Z:\\Основы алгоритмизации 2017-2018\\csharp\\files\\task4954\\test" + n + ".txt";
            if (!File.Exists(A)) //проверяет наличие файла
            {
                Console.Write("oshibka fail ne sushestvuet");
                return;
            }
            StreamReader reader = new StreamReader(A); //читает файл
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
