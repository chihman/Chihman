﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_9_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite nomer testa ");
            int n = int.Parse(Console.ReadLine());

            if (!File.Exists("..\\..\\data" + n + ".txt")) //проверяет наличие файла
            {
                Console.Write("oshibka fail ne sushestvuet");
                return;
            }
            StreamReader reader = new StreamReader("..\\..\\data" + n + ".txt"); //читает файл
            if (reader.EndOfStream)
            {
                Console.Write("Файл пуст");
                return;
            }



            int x = 0;

            while (!reader.EndOfStream)
            {



                String line = reader.ReadLine(); //читает первую строку
            }
        }
    }
}
