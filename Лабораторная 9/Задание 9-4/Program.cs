﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int i = 0;
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
            String b = "";
            int x = 0;
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine(); //читает первую строку
                                                 //
                String[] a = line.Split(' ');
                int L = a.Length;
                i = 0;
                while (i < L)
                {
                    if (a[i] != b)
                    {
                        x++;
                    }
                    i++;
                   
                }
                Console.Write(x + " ");
            }

        }
    }
}
