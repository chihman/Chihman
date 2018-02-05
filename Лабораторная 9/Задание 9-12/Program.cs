using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_9_12
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
            String text;
            int x, y, i=0;
            while (!reader.EndOfStream)
            {
                x = 0;
                y = 0;
                String line = reader.ReadLine(); //читает первую строку
                int L = line.Length;
                x = line.IndexOf("=\"");
                y= line.IndexOf("\">");
                if (x > 0)
                {
                    Console.WriteLine(text = line.Substring(x+2, y-x-2));
                    i++;
                }
            }
            if (i < 1) { Console.Write("OSHIBKA! "); }
        }
    }
}
