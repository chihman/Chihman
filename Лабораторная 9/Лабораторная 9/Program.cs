using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//обязательная строка

namespace Лабораторная_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ibibib");
            return;
            if (File.Exists("test1.txt")) //проверяет наличие файла
            { };
            StreamReader reader = new StreamReader("test1.txt"); //читает файл
            if (reader.EndOfStream)//индикатор окончания файла тру только в конце файла
               
            { line = reader.ReadLine(); } 
            String line =reader.ReadLine(); //читает первую строку
            
        }
    }
}
