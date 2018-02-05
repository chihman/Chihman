using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_9_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite nomer testa ");
            int n = int.Parse(Console.ReadLine());

            if (!File.Exists("..\\..\\test" + n + ".html")) //проверяет наличие файла
            {
                Console.Write("oshibka fail ne sushestvuet");
                return;
            }
            StreamReader reader = new StreamReader("..\\..\\test" + n + ".html"); //читает файл
            if (reader.EndOfStream)
            {
                Console.Write("Файл пуст");
                return;
            }
            String text, text2;
            int x, y, i = 0;
            while (!reader.EndOfStream)
            {
                x = 0;
                y = 0;


                String line = reader.ReadLine(); //читает первую строку
                
                int L = line.Length;
                if (i >= 1)
                { Console.Write("&"); }
                i = 0;
                x = line.IndexOf("name=\"");
                y = line.IndexOf(">");
               
                if (x > 0)
                {
                   text = line.Substring(x+6 , y - x - 8);
                    text = text.Replace(" ", "+");
                    Console.Write(text + "=");
                    i++;

                }
                x = 0;
                y = 0;
                x = line.IndexOf("value=\"");
                y = line.IndexOf("\" name");
                if (x > 0)
                {
                    text = line.Substring(x , y - x );//oshibka
                    text = text.Replace(" ", "+");
                   
                    string s2 = text.Trim(" \"\"".ToCharArray());
                    Console.Write(s2);
                }
               
            }
            if (i < 1) { Console.Write("OSHIBKA! "); }
        }
    }
}
